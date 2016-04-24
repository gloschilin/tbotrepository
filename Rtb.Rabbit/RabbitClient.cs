using System;
using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace Rtb.Rabbit
{
    /// <summary>
    /// Interface for send message to rebit server
    /// </summary>
    public abstract class RabbitClient<TMessage> : IDisposable
    {
        private readonly string _rabbitHostName;
        private IModel _chanelModel;
        private IConnection _connection;

        /// <summary>
        /// Queue name
        /// </summary>
        protected abstract string QueueName { get; }


        public RabbitClient(string rabbitHostName)
        {
            _rabbitHostName = rabbitHostName;
        }

        protected void Init()
        {
            var factory = new ConnectionFactory { HostName = _rabbitHostName };
            _connection = factory.CreateConnection();
            _chanelModel = _connection.CreateModel();
            _chanelModel.QueueDeclare(QueueName, false, false, false, null);
        }
        
        /// <summary>
        /// Send message to rabit server
        /// </summary>
        public virtual void Send(TMessage message)
        {
            var json = JsonConvert.SerializeObject(message);
            var messageId = Guid.NewGuid();
            var messageToSend = new RabbitMessage
            {
                MessageJson = json,
                MessageId = messageId
            };

            var jsonToSend = JsonConvert.SerializeObject(messageToSend);
            var body = Encoding.UTF8.GetBytes(jsonToSend);

            _chanelModel.BasicPublish("", QueueName, null, body);
        }

        public void Dispose()
        {
            _connection.Dispose();
            _chanelModel.Dispose();
        }
    }
}
