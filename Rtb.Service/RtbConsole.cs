using System;
using System.Runtime.InteropServices;
using Microsoft.Practices.Unity;
using Rtb.Entity.Telegram;
using Rtb.Rabbit;

namespace Rtb.Service
{
    public static class RtbConsole
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeConsole();

        [STAThread]
        public static void Start(RabbitServer<Update> rabbitUpdateServer)
        {
            AllocConsole();

            Console.WriteLine(@"Console mode started...");
            Console.ReadLine();
            
            rabbitUpdateServer.Run();

            FreeConsole();
        }
    }
}
