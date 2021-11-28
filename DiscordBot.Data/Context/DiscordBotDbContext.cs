namespace DiscordBot.Data.Context;

public class DiscordBotDbContext : DbContext
{
    public DiscordBotDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Guild> Guilds { get; set; }
}
