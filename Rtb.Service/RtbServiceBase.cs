using System.ServiceProcess;
using Rtb.Core.Interface;
using Rtb.Rabbit;

namespace Rtb.Service
{
    public abstract class RtbServiceBase : ServiceBase
    {
        private readonly IServer _server;

        public RtbServiceBase(IServer server)
        {
            _server = server;
        }

        protected override void OnStart(string[] args)
        {
            _server.Run();
        }

        protected override void OnStop()
        {
            _server.Dispose();
        }
    }
}
