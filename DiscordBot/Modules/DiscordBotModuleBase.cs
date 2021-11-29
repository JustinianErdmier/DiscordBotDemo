namespace DiscordBot.Modules;

public abstract class DiscordBotModuleBase : ModuleBase<SocketCommandContext>
{
    public readonly DataAccessLayer DataAccessLayer;

    public string Prefix
    {
        get
        {
            if (string.IsNullOrEmpty(_prefix))
            {
                _prefix = DataAccessLayer.GetPrefix(Context.Guild.Id);
            }

            return _prefix;
        }
    }

    private string _prefix;

    public DiscordBotModuleBase(DataAccessLayer dataAccessLayer)
    {
        DataAccessLayer = dataAccessLayer;
    }

    public async Task<RestUserMessage> SendEmbedAsync(string title, string description)
    {
        var builder = new EmbedBuilder()
            .WithTitle(title)
            .WithDescription(description);

        return await Context.Channel.SendMessageAsync(embed: builder.Build());
    }
}
