using Newtonsoft.Json;

namespace HassClient.Core.Models
{
    /// <summary>
    /// .
    /// </summary>
    public class ConversationResponse
    {
        /// <summary>
        /// .
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// .
        /// </summary>
        [JsonProperty(PropertyName = "response_type")]
        public string ResponseType { get; set; }

        /// <summary>
        /// .
        /// </summary>
        [JsonProperty(PropertyName = "speech")]
        public ConversationSpeech Speech { get; set; }
    }
}
