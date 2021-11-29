namespace DiscordBot.Data.Models;

/// <summary>
/// Model used by EFCore.
/// </summary>
public class Guild
{
    /// <summary>
    /// Gets or Sets the unique identifier for the Discord Server.
    /// </summary>
    public ulong Id { get; set; }

    /// <summary>
    /// Gets or Sets the prefix for bot commands.
    /// </summary>
    public string Prefix { get; set; } = "!";
}
