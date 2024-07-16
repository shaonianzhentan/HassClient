namespace HassClient.WS.Messages
{
    internal class PushNotificationConfirm : BaseOutgoingMessage
    {
        public PushNotificationConfirm()
            : base("mobile_app/push_notification_confirm")
        {
        }

        public string WebhookID { get; set; }

        public string ConfirmID { get; set; }
    }
}
