using System.Collections.Generic;

namespace Rtb.Core.Interface
{
    /// <summary>
    /// Notification from services
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public interface INotification<in TData>
    {
        /// <summary>
        /// Identity alias notification
        /// </summary>
        string Alias { get; }

        /// <summary>
        /// Description notification
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Get handlers for notification
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        IEnumerable<INotificationHandler<TData>> GetHandlers(TData data);
    }
}