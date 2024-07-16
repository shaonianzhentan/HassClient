using HassClient.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HassClient.Models
{
    /// <summary>
    /// https://companion.home-assistant.io/docs/notifications/notifications-basic
    /// 推送通知事件信息.
    /// </summary>
    public class MobileAppPushNotification
    {
        /// <summary>
        /// 确认ID.
        /// </summary>
        [JsonProperty]
        public string HassConfirmID { get; set; }

        /// <summary>
        /// Message.
        /// </summary>
        [JsonProperty]
        public string Message { get; set; }

        /// <summary>
        /// Title.
        /// </summary>
        [JsonProperty]
        public string Title { get; set; }

        /// <summary>
        /// Target.
        /// </summary>
        [JsonProperty]
        public JRaw Target { get; set; }

        /// <summary>
        /// Data.
        /// </summary>
        [JsonProperty]
        public Dictionary<string, JRaw> Data { get; set; }

        /// <summary>
        /// Attempts to get the value of the specified data by <paramref name="name"/>,
        /// and cast the value to type <typeparamref name="T" />.
        /// </summary>
        /// <typeparam name="T">The desired type to cast the data value to.</typeparam>
        /// <param name="name">The name of the data to retrieve the value for.</param>
        /// <returns>The data's current value, cast to type <typeparamref name="T" />.</returns>
        public T GetDataValue<T>(string name) => this.Data == null ? default : (!this.Data.ContainsKey(name) ? default : HassSerializer.DeserializeObject<T>(this.Data[name]));

        /// <summary>
        /// Attempts to get the values of the specified data by <paramref name="name"/> as an
        /// <see cref="IEnumerable{T}"/>.
        /// <para>
        /// If the data is not defined, an empty enumeration will be returned.
        /// </para>
        /// </summary>
        /// <exception cref="InvalidCastException">Thrown when the specified type <typeparamref name="T"/>
        /// cannot be cast to the data's current value.</exception>
        /// <typeparam name="T">The desired type to cast the data values to.</typeparam>
        /// <param name="name">The name of the data to retrieve the values for.</param>
        /// <returns>
        /// An enumeration containing data's current values, cast to type <typeparamref name="T" />.
        /// </returns>
        public IEnumerable<T> GetDataValues<T>(string name)
        {
            return this.GetDataValue<IEnumerable<T>>(name) ?? Enumerable.Empty<T>();
        }

        /// <summary>
        /// Actionable Notifications.
        /// </summary>
        public IEnumerable<MobileAppPushNotificationAction> Actions => this.GetDataValues<MobileAppPushNotificationAction>("actions");
    }
}
