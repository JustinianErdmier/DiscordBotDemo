namespace DiscordBot.Common;

/// <summary>
/// A custom builder with a theme.
/// </summary>
internal class DiscordBotEmbedBuilder : EmbedBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DiscordBotEmbedBuilder"/> class.
    /// </summary>
    public DiscordBotEmbedBuilder()
    {
        WithColor(new Color(238, 62, 75));
    }
}
