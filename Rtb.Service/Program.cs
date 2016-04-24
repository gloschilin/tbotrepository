using System;
using Microsoft.Practices.Unity;
using Rtb.Entity.Telegram;
using Rtb.Rabbit;

namespace Rtb.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            
            RegisterTypes(Container.Value);

            var telegramUpdateMessageServer = Container.Value.Resolve<RabbitServer<Update>>();

#if (DEBUG)
            RtbConsole.Start(telegramUpdateMessageServer);
#else
            var servicesToRun = new ServiceBase[]
            {
                new RtbService(telegramUpdateMessageServer)
            };
            ServiceBase.Run(servicesToRun);
#endif
        }

        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        private static void RegisterTypes(IUnityContainer container)
        {
            //register application types

        }
    }
}
