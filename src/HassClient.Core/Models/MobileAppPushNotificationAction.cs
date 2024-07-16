using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HassClient.Models
{
    /// <summary>
    /// https://companion.home-assistant.io/docs/notifications/actionable-notifications
    /// 推送通知操作按钮.
    /// </summary>
    public class MobileAppPushNotificationAction
    {
        /// <summary>
        /// Required. The identifier passed back in events.
        /// </summary>
        [JsonProperty]
        public string Action { get; set; }

        /// <summary>
        /// Required. The title of the button shown in the notification.
        /// </summary>
        [JsonProperty]
        public string Title { get; set; }

        /// <summary>
        /// Optional. The URL to open when tapped.
        /// </summary>
        [JsonProperty]
        public string Uri { get; set; }
    }
}
