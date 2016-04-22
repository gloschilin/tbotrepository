using Newtonsoft.Json;

namespace Rtb.Rabbit
{
    /// <summary>
    /// Default rebit client
    /// </summary>
    public class RebitClient : IRebitClient
    {
        public void Send<TMessage>(TMessage message) where TMessage : class
        {
            var typeName = message.GetType().FullName;
            var json = JsonConvert.SerializeObject(message);

            var messageToSend = new RabitMessage
            {
                MessageDataType = typeName,
                MessageJson = json
            };

            var jsonToSend = JsonConvert.SerializeObject(messageToSend);

            //TODO send messsage in rebit
        }
    }
}