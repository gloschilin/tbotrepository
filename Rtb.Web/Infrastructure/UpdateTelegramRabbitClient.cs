using Rtb.Entity.Telegram;
using Rtb.Rabbit;

namespace Rtb.Web.Infrastructure
{
    /// <summary>
    /// Rabbit client for update message
    /// </summary>
    public class UpdateTelegramRabbitClient: RabbitClient<Update>
    {
        public UpdateTelegramRabbitClient(string rabbitHostName) 
            : base(rabbitHostName)
        {
            
        }

        protected override string QueueName => "TelegramUpdate";
    }
}