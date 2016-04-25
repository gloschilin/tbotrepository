using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Rtb.Core.Interface;
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
        public static void Start(IReadOnlyCollection<IServer> serversToRun)
        {
            AllocConsole();

            Console.WriteLine(@"Console mode started...");

            foreach (var server in serversToRun)
            {
                server.Run();
                Console.WriteLine($"Server {server.GetType()} started");
            }

            Console.ReadLine();

            foreach (var server in serversToRun)
            {
                server.Dispose();
                Console.WriteLine($"Server {server.GetType()} stoped");
            }

            FreeConsole();
        }
    }
}
