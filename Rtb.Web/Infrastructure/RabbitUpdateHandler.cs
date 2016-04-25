using Rtb.Core.Interface;
using Rtb.Entity.Telegram;
using Rtb.Rabbit;

namespace Rtb.Web.Infrastructure
{
    /// <summary>
    /// Hendler send message on rebit server with update command
    /// </summary>
    public class RabbitUpdateHandler : INotificationHandler<Update>
    {
        private readonly RabbitClient<Update> _rebitClient;

        public RabbitUpdateHandler(RabbitClient<Update> rebitClient)
        {
            _rebitClient = rebitClient;
        }

        public void Handle(Update data)
        {
            _rebitClient.Send(data);
        }
    }
}