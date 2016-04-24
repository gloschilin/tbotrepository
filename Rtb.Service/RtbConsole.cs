using System;
using System.Runtime.InteropServices;
using Microsoft.Practices.Unity;

namespace Rtb.Service
{
    public static class RtbConsole
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeConsole();

        [STAThread]
        public static void Start(IUnityContainer container)
        {
            AllocConsole();

            Console.WriteLine(@"Console mode started...");
            Console.ReadLine();

            FreeConsole();
        }
    }
}
