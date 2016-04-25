using Rtb.Service.Infrastructure;

namespace Rtb.Service.Services
{
    partial class TelegramUpdateService : RtbServiceBase
    {
        public TelegramUpdateService(UpdateTelegramRabbitServer server) : base(server)
        {
            InitializeComponent();
        }
    }
}
