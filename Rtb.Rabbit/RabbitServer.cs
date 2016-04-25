using System.Text;
using System.Threading;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Rtb.Core.Interface;

namespace Rtb.Rabbit
{
    /// <summary>
    /// Redis server
    /// </summary>
    public abstract class RabbitServer<TMessage>: IServer
        where TMessage : class
    {
        private readonly string _rabbitHostName;
        private IConnection _connection;
        private IModel _channel;

        /// <summary>
        /// Queue name
        /// </summary>
        protected abstract string QueueName { get; }

        public RabbitServer(string rabbitHostName)
        {
            _rabbitHostName = rabbitHostName;
        }

        //TODO: into interface
        public void Run()
        {
            var factory = new ConnectionFactory() { HostName = _rabbitHostName };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();

            _channel.QueueDeclare(QueueName, false, false, false, null);

            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += ConsumerReceivedInternal;
            _channel.BasicConsume(QueueName, true, consumer);
        }

        /// <summary>
        /// Exec when concumer received message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ConsumerReceivedInternal(object sender, BasicDeliverEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(state =>
            {
                var body = e.Body;
                var messageJson = Encoding.UTF8.GetString(body);
                var rabbitMassge = JsonConvert.DeserializeObject<RabbitMessage<TMessage>>(messageJson);

                ConsumerReceived(rabbitMassge.Message);
            });
        }

        protected abstract void ConsumerReceived(TMessage rabbitMassge);
        
        public void Dispose()
        {
            _channel.Dispose();
            _connection.Dispose();
        }
    }
}
