﻿using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using WorldState.Data.Enums;
using WorldState.Data.Interfaces;

namespace WorldState.Data.Models
{
    public class OrbVallisCycle : ITimeSensitive
    {
        [JsonProperty]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public DateTimeOffset ActivatedAt { get; private set; }

        [JsonProperty("expiry")]
        public DateTimeOffset ExpiresAt { get; private set; }

        [JsonProperty()]
        [JsonConverter(typeof(StringEnumConverter))]
        public OrbVallisSeason Season { get; private set; }
    }
}
