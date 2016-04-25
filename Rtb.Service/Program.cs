using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Rtb.Core.Interface;
using Rtb.Entity.Telegram;
using Rtb.Rabbit;
using Rtb.Service.Infrastructure;

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

#if (DEBUG)
            var serversToRun = Container.Value.Resolve<IEnumerable<IServer>>();
            RtbConsole.Start(serversToRun);
#else
            //var servicesToRun = new ServiceBase[]
            //{
            //    new RtbServiceBase(telegramUpdateMessageServer)
            //};
            //ServiceBase.Run(servicesToRun);
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
            container.RegisterType<IEnumerable<IServer>, IServer[]>();
            container.RegisterType<IServer, UpdateTelegramRabbitServer>("UpdateTelegramRabbitServer");
        }
    }
}
