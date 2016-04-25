using System;

namespace Rtb.Core.Interface
{
    /// <summary>
    /// Server interface
    /// </summary>
    public interface IServer : IDisposable
    {
        /// <summary>
        /// Start server
        /// </summary>
        void Run();
    }
}