namespace Rtb.Rabbit
{
    /// <summary>
    /// Interface for send message to rebit server
    /// </summary>
    public interface IRebitClient
    {
        /// <summary>
        /// Send message to rabit server
        /// </summary>
        /// <typeparam name="TMessage"></typeparam>
        /// <param name="message"></param>
        void Send<TMessage>(TMessage message) where TMessage : class;
    }
}
