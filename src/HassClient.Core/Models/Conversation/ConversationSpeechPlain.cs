﻿using Newtonsoft.Json;

namespace HassClient.Models
{
    /// <summary>
    /// .
    /// </summary>
    public class ConversationSpeechPlain
    {
        /// <summary>
        /// .
        /// </summary>
        [JsonProperty(PropertyName = "speech")]
        public string Speech { get; set; }
    }
}
