namespace DiscordBot.Models;

public partial class Event
{
    [JsonProperty("activity", NullValueHandling = NullValueHandling.Ignore)]
    public string Activity { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    [JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
    public long? Participants { get; set; }

    [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
    public double? Price { get; set; }

    [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
    public string Link { get; set; }

    [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(ParseStringConverter))]
    public long? Key { get; set; }

    [JsonProperty("accessibility", NullValueHandling = NullValueHandling.Ignore)]
    public double? Accessibility { get; set; }
}

public partial class Event
{
    public static Event FromJson(string json) => JsonConvert.DeserializeObject<Event>(json, Converter.Settings);
}
