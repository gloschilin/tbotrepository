using System;
using Rtb.Core.Interface;
using Rtb.Entity.Telegram;
using Rtb.Rabbit;

namespace Rtb.Service.Infrastructure
{
    /// <summary>
    /// Received when clinet send telegram update message
    /// </summary>
    public class UpdateTelegramRabbitServer : RabbitServer<Update>
    {
        public UpdateTelegramRabbitServer(IConstantsContainer constantsContainer) 
            : base(constantsContainer)
        {
        }

        protected override string QueueName => "TelegramUpdate";

        protected override void ConsumerReceived(Update rabbitMassge)
        {
            throw new NotImplementedException();
        }
    }
}
