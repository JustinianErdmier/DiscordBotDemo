namespace DiscordBot.Modules;

public class General : DiscordBotModuleBase
{
    private readonly IHttpClientFactory _httpClientFactory;

    public General(IHttpClientFactory httpClientFactory, DataAccessLayer dataAccessLayer) : base(dataAccessLayer)
    {
        _httpClientFactory = httpClientFactory;
    }

    [Command("ping")]
    [Alias("p")]
    public async Task PingAsync()
    {
        await Context.Channel.Trigger
            https://github.com/Coding-with-Efehan/Watermelon-DNBDS/blob/master/Watermelon/Modules/General.cs
    }
}
