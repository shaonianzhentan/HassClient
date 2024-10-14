using Newtonsoft.Json;

namespace HassClient.Models
{
    /// <summary>
    /// .
    /// </summary>
    public class HassAuthClientInfo
    {
        /// <summary>
        /// .
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// client_id.
        /// </summary>
        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// client_name.
        /// </summary>
        [JsonProperty(PropertyName = "client_name")]
        public string ClientName { get; set; }

        /// <summary>
        /// .
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
