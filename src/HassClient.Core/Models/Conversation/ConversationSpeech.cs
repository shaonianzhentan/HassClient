using Newtonsoft.Json;

namespace HassClient.Models
{
    /// <summary>
    /// .
    /// </summary>
    public class ConversationSpeech
    {
        /// <summary>
        /// .
        /// </summary>
        [JsonProperty(PropertyName = "plain")]
        public ConversationSpeechPlain Plain { get; set; }
    }
}
