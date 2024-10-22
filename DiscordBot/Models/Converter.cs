﻿namespace DiscordBot.Models;

internal static class Converter
{
    public static readonly JsonSerializerSettings Settings = new ()
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
        {
            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal },
        },
    };
}
