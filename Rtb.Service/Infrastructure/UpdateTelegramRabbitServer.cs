using System;
using Rtb.Entity.Telegram;
using Rtb.Rabbit;

namespace Rtb.Service.Infrastructure
{
    /// <summary>
    /// Received when clinet send telegram update message
    /// </summary>
    public class UpdateTelegramRabbitServer : RabbitServer<Update>
    {
        public UpdateTelegramRabbitServer(string rabbitHostName) : base(rabbitHostName)
        {
        }

        protected override string QueueName => "TelegramUpdate";

        protected override void ConsumerReceived(Update rabbitMassge)
        {
            throw new NotImplementedException();
        }
    }
}
