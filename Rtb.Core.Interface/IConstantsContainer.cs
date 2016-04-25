namespace Rtb.Core.Interface
{
    /// <summary>
    /// Application constants
    /// </summary>
    public interface IConstantsContainer
    {
        /// <summary>
        /// Repository telegram bot key
        /// </summary>
        string ApplicationKey { get; }

        /// <summary>
        /// Rabit host
        /// </summary>
        string RabbitHost { get; }
    }
}