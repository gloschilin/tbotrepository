using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Rtb.Core;
using Rtb.Core.Interface;
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
            var serversToRun = Container.Value.Resolve<IEnumerable<IServer>>().ToArray();
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
            container.RegisterType<IConstantsContainer, ConfigConstantsContainer>();
            container.RegisterType<IEnumerable<IServer>, IServer[]>();
            container.RegisterType<IServer, UpdateTelegramRabbitServer>("UpdateTelegramRabbitServer",
                new InjectionConstructor(container.Resolve<IConstantsContainer>().RabbitHost)
            );
        }
    }
}
