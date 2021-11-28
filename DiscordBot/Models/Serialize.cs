namespace DiscordBot.Models;

public static class Serialize
{
    public static string ToJson(this Event self) => JsonConvert.SerializeObject(self, Converter.Settings);
}
