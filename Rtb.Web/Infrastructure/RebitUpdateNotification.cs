using Rtb.Entity.Telegram;
using Rtb.Rabbit;
using Rtb.Web.Controllers;

namespace Rtb.Web.Infrastructure
{
    /// <summary>
    /// Hendler send message on rebit server with update command
    /// </summary>
    public class RebitUpdateNotification : INotificationHandler<Update>
    {
        private readonly IRebitClient _rebitClient;

        public RebitUpdateNotification(IRebitClient rebitClient)
        {
            _rebitClient = rebitClient;
        }

        public void Handle(Update data)
        {
            _rebitClient.Send(data);
        }
    }
}