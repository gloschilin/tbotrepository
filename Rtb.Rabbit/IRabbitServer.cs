using System;

namespace Rtb.Rabbit
{
    /// <summary>
    /// Redis server
    /// </summary>
    public interface IRabbitServer: IDisposable
    {
        void Run();
    }
}
