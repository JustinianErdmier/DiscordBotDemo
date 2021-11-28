namespace DiscordBot.Services;

public abstract class DiscordBotService : DiscordClientService
{
    public readonly DiscordSocketClient Client;
    public readonly ILogger<DiscordClientService> Logger;
    public readonly IConfiguration Configuration;
    public readonly DataAccessLayer DataAccessLayer;

    public DiscordBotService(DiscordSocketClient client, ILogger<DiscordClientService> logger, IConfiguration configuration, DataAccessLayer dataAccessLayer) : base(client, logger)
    {
        Client = client;
        Logger = logger;
        Configuration = configuration;
        DataAccessLayer = dataAccessLayer;
    }
}
