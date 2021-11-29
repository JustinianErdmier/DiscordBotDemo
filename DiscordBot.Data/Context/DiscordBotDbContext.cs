namespace DiscordBot.Data.Context;

/// <summary>
/// The context for our database.
/// </summary>
public class DiscordBotDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DiscordBotDbContext"/> class.
    /// </summary>
    /// <param name="options">The options used to specify how the context should be instantiated.</param>
    public DiscordBotDbContext(DbContextOptions options)
        : base(options) { }

    /// <summary>
    /// Gets or Sets the database context model.
    /// </summary>
    public DbSet<Guild> Guilds { get; set; }
}
