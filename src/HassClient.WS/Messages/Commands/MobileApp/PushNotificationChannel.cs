namespace HassClient.WS.Messages
{
    internal class PushNotificationChannel : BaseOutgoingMessage
    {
        public PushNotificationChannel()
            : base("mobile_app/push_notification_channel")
        {
        }

        public string WebhookID { get; set; }

        public bool SupportConfirm { get; set; }
    }
}
