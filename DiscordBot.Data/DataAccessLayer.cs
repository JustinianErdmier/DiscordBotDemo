namespace DiscordBot.Data;

/// <summary>
/// The service layer that keeps our bot and data separate.
/// </summary>
public class DataAccessLayer
{
    private readonly IDbContextFactory<DiscordBotDbContext> _dbContextFactory;

    /// <summary>
    /// Initializes a new instance of the <see cref="DataAccessLayer"/> class.
    /// </summary>
    /// <param name="dbContextFactory">An instance of the DbContextFactory.</param>
    public DataAccessLayer(IDbContextFactory<DiscordBotDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    /// <summary>
    /// Creates a new Guild object and persists it to the database.
    /// </summary>
    /// <param name="id">The unique identifier for the Discord server.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task CreateGuild(ulong id)
    {
        using var context = _dbContextFactory.CreateDbContext();
        if (context.Guilds.Any(x => x.Id == id)) return;

        context.Add(new Guild { Id = id });
        await context.SaveChangesAsync();
    }

    /// <summary>
    /// Gets the Guild's set prefix.
    /// </summary>
    /// <param name="id">The unique identifier for the Discord server.</param>
    /// <returns>The set prefix for the Discord server.</returns>
    public string GetPrefix(ulong id)
    {
        using var context = _dbContextFactory.CreateDbContext();
        var guild = context.Guilds.Find(id);

        if (guild == null)
        {
            guild = context.Add(new Guild { Id = id }).Entity;
            context.SaveChanges();
        }

        return guild.Prefix;
    }

    /// <summary>
    /// Sets the Guild's prefix.
    /// </summary>
    /// <param name="id">The unique identifier for the Discord server.</param>
    /// <param name="prefix">The desired prefix to identify bot commands.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task SetPrefix(ulong id, string prefix)
    {
        using var context = _dbContextFactory.CreateDbContext();
        var guild = await context.Guilds.FindAsync(id);

        if (guild != null)
        {
            guild.Prefix = prefix;
        }
        else context.Add(new Guild { Id = id });

        await context.SaveChangesAsync();
    }

    /// <summary>
    /// Deletes the Guild.
    /// </summary>
    /// <param name="id">The unique identifier for the Discord server.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task DeleteGuild(ulong id)
    {
        using var context = _dbContextFactory.CreateDbContext();
        var guild = await context.Guilds.FindAsync(id);

        if (guild == null) return;

        context.Remove(guild);
        await context.SaveChangesAsync();
    }
}
