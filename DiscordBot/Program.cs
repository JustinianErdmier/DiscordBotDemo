namespace DiscordBot;

internal class Program
{
    private static async Task Main()
    {
        var builder = new HostBuilder()
            .ConfigureAppConfiguration(x =>
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", false, true)
                    .Build();

                x.AddConfiguration(configuration);
            })
            .ConfigureLogging(x =>
            {
                x.AddConsole();
                x.SetMinimumLevel(LogLevel.Debug);
            })
            .ConfigureDiscordHost((context, config) =>
            {
                config.SocketConfig = new DiscordSocketConfig
                {
                    LogLevel = LogSeverity.Debug,
                    AlwaysDownloadUsers = true,
                    MessageCacheSize = 200,
                };

                config.Token = context.Configuration["Token"];
            })
            .UseCommandService((context, config) =>
            {
                config.CaseSensitiveCommands = false;
                config.LogLevel = LogSeverity.Debug;
                config.DefaultRunMode = RunMode.Sync;
            })
            .ConfigureServices((context, services) =>
            {
                services.AddHostedService<CommandHandler>();
                services.AddHttpClient();
                services.AddDbContextFactory<DiscordBotDbContext>(options =>
                options.UseMySql(
                    context.Configuration.GetConnectionString("Default"),
                    new MySqlServerVersion(new Version(8, 0, 27))))
                .AddSingleton<DataAccessLayer>();
            })
            .UseConsoleLifetime();

        var host = builder.Build();
        using (host)
        {
            await host.RunAsync();
        }
    }
}