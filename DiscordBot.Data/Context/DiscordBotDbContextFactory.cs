namespace DiscordBot.Data.Context;

/// <summary>
/// Class that allows us to create and manage multiple instances of our database context.
/// </summary>
public class DiscordBotDbContextFactory : IDesignTimeDbContextFactory<DiscordBotDbContext>
{
    /// <summary>
    /// Creates a database context.
    /// </summary>
    /// <param name="args">An array of strings.</param>
    /// <returns>A new database context.</returns>
    public DiscordBotDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, true)
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder()
            .UseMySql(
                configuration.GetConnectionString("Default"),
                new MySqlServerVersion(new Version(8, 0, 27)));

        return new DiscordBotDbContext(optionsBuilder.Options);
    }
}
