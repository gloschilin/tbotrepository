using System.ServiceProcess;
using Rtb.Entity.Telegram;
using Rtb.Rabbit;

namespace Rtb.Service
{
    public partial class RtbService : ServiceBase
    {
        private readonly RabbitServer<Update> _telegramUpdateRabbitServer;
 
        public RtbService(RabbitServer<Update> telegramUpdateRabbitServer)
        {
            _telegramUpdateRabbitServer = telegramUpdateRabbitServer;
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _telegramUpdateRabbitServer.Run();
        }

        protected override void OnStop()
        {
            _telegramUpdateRabbitServer.Dispose();
        }
    }
}
