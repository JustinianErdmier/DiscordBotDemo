namespace DiscordBot.Services;

public class CommandHandler : DiscordBotService
{
    private readonly IServiceProvider _provider;
    private readonly DiscordSocketClient _client;
    private readonly CommandService _service;
    private readonly IConfiguration _configuration;

    public CommandHandler(IServiceProvider provider, DiscordSocketClient client, CommandService service, IConfiguration configuration, ILogger<DiscordClientService> logger, DataAccessLayer dataAccessLayer) : base(client,logger, configuration, dataAccessLayer)
    {
        _provider = provider;
        _client = client;
        _service = service;
        _configuration = configuration;
    }
    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        _client.MessageReceived += OnMessageReceived;
        _service.CommandExecuted += OnCommandExecuted;
        await _service.AddModulesAsync(Assembly.GetEntryAssembly(), _provider);
    }

    private async Task OnCommandExecuted(Optional<CommandInfo> commandInfo, ICommandContext commandContext, IResult result)
    {
        if (result.IsSuccess) return;

        await commandContext.Channel.SendMessageAsync(result.ErrorReason);
    }

    private async Task OnMessageReceived(SocketMessage socketMessage)
    {
        if (socketMessage is not SocketUserMessage message) return;
        if (message.Source != MessageSource.User) return;

        int argPos = 0;
        var user = message.Author as SocketGuildUser;
        var prefix = DataAccessLayer.GetPrefix(user.Guild.Id);
        if (!message.HasStringPrefix(prefix, ref argPos) && !message.HasMentionPrefix(_client.CurrentUser, ref argPos)) return;

        var context = new SocketCommandContext(_client, message);
        await _service.ExecuteAsync(context, argPos, _provider);
    }
}
