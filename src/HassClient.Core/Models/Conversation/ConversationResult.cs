using Newtonsoft.Json;

namespace HassClient.Models
{
    /// <summary>
    /// .
    /// </summary>
    public class ConversationResult
    {
        /// <summary>
        /// .
        /// </summary>
        [JsonProperty(PropertyName = "conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// .
        /// </summary>
        [JsonProperty(PropertyName = "response")]
        public ConversationResponse Response { get; set; }
    }
}
