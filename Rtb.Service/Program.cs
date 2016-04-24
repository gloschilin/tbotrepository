using System;
using Microsoft.Practices.Unity;

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
            RtbConsole.Start(Container.Value);
#else
            var servicesToRun = new ServiceBase[]
            {
                new RtbService()
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
