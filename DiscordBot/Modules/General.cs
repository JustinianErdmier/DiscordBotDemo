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
        await Context.Channel.TriggerTypingAsync();
        await Context.Channel.SendMessageAsync();
    }

    [Command("prefix")]
    public async Task PrefixAsync(DataAccessLayer dataAccessLayer, string prefix = null)
    {
        if (prefix == null)
        {
            await ReplyAsync($"The prefix of this guild is {prefix}.");
            return;
        }

        await dataAccessLayer.SetPrefix(Context.Guild.Id, prefix);
        await ReplyAsync($"The prefix has been set to {prefix}.");
    }

    [Command("info")]
    public async Task InfoAsync(SocketGuildUser socketGuildUser = null)
    {
        if (socketGuildUser == null)
        {
            socketGuildUser = Context.User as SocketGuildUser;
        }

        var embed = new DiscordBotEmbedBuilder()
            .WithTitle($"{socketGuildUser.Username}#{socketGuildUser.Discriminator}")
            .AddField("ID", socketGuildUser.Id, true)
            .AddField("Name", $"{socketGuildUser.Username}#{socketGuildUser.Discriminator}", true)
            .AddField("Created at", socketGuildUser.CreatedAt, true)
            .WithThumbnailUrl(socketGuildUser.GetAvatarUrl() ?? socketGuildUser.GetDefaultAvatarUrl())
            .WithCurrentTimestamp()
            .Build();

        await ReplyAsync(embed: embed);
    }

    [Command("activity")]
    public async Task Activity()
    {
        var httpClient = _httpClientFactory.CreateClient();
        var response = await httpClient.GetStringAsync("https://www.boredapi.com/api/activity/");
        var activity = Event.FromJson(response);

        if (activity == null)
        {
            await ReplyAsync("An error occured, please try again later.");
            return;
        }

        await ReplyAsync($"**Activity:** {activity.Activity}\n**Participants:** {activity.Participants}\n**Type:** {activity.Price}\n**Accessibility:** {activity.Accessibility}");
    }

    [Command("embed")]
    public async Task Embed(string title)
    {
        await SendEmbedAsync(title, "Bla bla bla");
    }
}
