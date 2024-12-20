﻿using Newtonsoft.Json;

namespace PlayerDotNet.models
{
    public class GameState
    {
        [JsonProperty("actions")]
        public required List<BoardAction> Actions { get; set; }

        [JsonProperty("bases")]
        public required List<Base> Bases { get; set; }

        [JsonProperty("config")]
        public required GameConfig Config { get; set; }

        [JsonProperty("game")]
        public required Game Game { get; set; }
    }
}
