namespace DiscordBot.Data.Context;

public class DiscordBotDbContextFactory : IDesignTimeDbContextFactory<DiscordBotDbContext>
{
    public DiscordBotDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, true)
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder()
            .UseMySql(configuration.GetConnectionString("Default"),
            new MySqlServerVersion(new Version(8, 0, 27)));

        return new DiscordBotDbContext(optionsBuilder.Options);
    }
}
