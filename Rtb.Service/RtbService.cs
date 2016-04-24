using System.ServiceProcess;
using Rtb.Rabbit;

namespace Rtb.Service
{
    public partial class RtbService : ServiceBase
    {
        private readonly IRabbitServer _rabbitServer;

        public RtbService(IRabbitServer rabbitServer)
        {
            _rabbitServer = rabbitServer;
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _rabbitServer.Run();
        }

        protected override void OnStop()
        {
            _rabbitServer.Dispose();
        }
    }
}
