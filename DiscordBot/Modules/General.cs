namespace DiscordBot.Modules;

/// <summary>
/// The general module containing commands like ping.
/// </summary>
public class General : DiscordBotModuleBase
{
    private readonly IHttpClientFactory _httpClientFactory;

    /// <summary>
    /// Initializes a new instance of the <see cref="General"/> class.
    /// </summary>
    /// <param name="httpClientFactory">The <see cref="IHttpClientFactory"/> to be used.</param>
    /// <param name="dataAccessLayer">The <see cref="DataAccessLayer"/> to be used.</param>
    public General(IHttpClientFactory httpClientFactory, DataAccessLayer dataAccessLayer)
        : base(dataAccessLayer)
    {
        _httpClientFactory = httpClientFactory;
    }

    /// <summary>
    /// A command that will respond with pong.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
    [Command("ping")]
    [Alias("p")]
    public async Task PingAsync()
    {
        await Context.Channel.TriggerTypingAsync();
        await Context.Channel.SendMessageAsync("Pong!");
    }

    /// <summary>
    /// A command that will either reply with the currently set prefix or allow the user to set a new prefix.
    /// </summary>
    /// <param name="prefix">When not null, is set to the prefix.</param>
    /// <returns>The currently set prefix or confirmation upon setting a new prefix.</returns>
    [Command("prefix")]
    public async Task PrefixAsync(string? prefix = null)
    {
        if (prefix == null)
        {
            await ReplyAsync($"The prefix of this guild is {Prefix}.");
            return;
        }

        await DataAccessLayer.SetPrefix(Context.Guild.Id, prefix);
        await ReplyAsync($"The prefix has been set to {prefix}.");
    }

    /// <summary>
    /// A command to get some information about a user.
    /// </summary>
    /// <param name="socketGuildUser">An optional user to get the information from.</param>
    /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
    [Command("info")]
    public async Task InfoAsync(SocketGuildUser? socketGuildUser = null)
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

    /// <summary>
    /// A command to get a randomly generated activity to do.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
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

    /// <summary>
    /// A command that allows the user to create embeds with custom titles.
    /// </summary>
    /// <param name="title">The title of the embed.</param>
    /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
    [Command("embed")]
    public async Task Embed(string title)
    {
        await SendEmbedAsync(title, "Bla bla bla");
    }
}
