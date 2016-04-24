using System;

namespace Rtb.Rabbit
{
    /// <summary>
    /// Rabbit message
    /// </summary>
    internal class RabbitMessage<TMessage>
        where TMessage : class 
    {
        /// <summary>
        /// Rabbit message identiry
        /// </summary>
        public Guid MessageId { get; set; }
        
        /// <summary>
        /// Message body
        /// </summary>
        public TMessage Message { get; set; }
    }
}