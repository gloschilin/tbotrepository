using System;

namespace Rtb.Rabbit
{
    /// <summary>
    /// Rabbit message
    /// </summary>
    internal class RabbitMessage
    {
        /// <summary>
        /// Rabbit message identiry
        /// </summary>
        public Guid MessageId { get; set; }
        
        /// <summary>
        /// Message body
        /// </summary>
        public string MessageJson { get; set; }
    }
}