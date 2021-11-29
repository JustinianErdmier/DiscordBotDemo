namespace DiscordBot.Services;

/// <summary>
/// A custom implementation of <see cref="DiscordClientService"/> for Watermelon.
/// </summary>
public abstract class DiscordBotService : DiscordClientService
{
    protected new readonly DiscordSocketClient Client;
    protected new readonly ILogger<DiscordClientService> Logger;
    protected readonly IConfiguration Configuration;
    protected readonly DataAccessLayer DataAccessLayer;

    /// <summary>
    /// Initializes a new instance of the <see cref="DiscordBotService"/> class.
    /// </summary>
    /// <param name="client">The <see cref="DiscordSocketClient"/> that should be injected.</param>
    /// <param name="logger">The <see cref="ILogger"/> that should be injected.</param>
    /// <param name="configuration">The <see cref="IConfiguration"/> that should be injected.</param>
    /// <param name="dataAccessLayer">The <see cref="DataAccessLayer"/> that should be injected.</param>
    public DiscordBotService(DiscordSocketClient client, ILogger<DiscordClientService> logger, IConfiguration configuration, DataAccessLayer dataAccessLayer)
        : base(client, logger)
    {
        Client = client;
        Logger = logger;
        Configuration = configuration;
        DataAccessLayer = dataAccessLayer;
    }
}
