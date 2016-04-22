namespace Rtb.Rabbit
{
    /// <summary>
    /// Rebbit message
    /// </summary>
    internal class RabitMessage
    {
        /// <summary>
        /// Message data type
        /// </summary>
        public string MessageDataType { get; set; }
        
        /// <summary>
        /// Message body
        /// </summary>
        public string MessageJson { get; set; }
    }
}