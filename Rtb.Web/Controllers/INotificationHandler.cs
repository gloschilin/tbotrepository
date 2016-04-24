namespace Rtb.Web.Controllers
{
    /// <summary>
    /// Handler for notification
    /// </summary>
    /// <typeparam name="TData">Notification parameter type</typeparam>
    public interface INotificationHandler<in TData>
    {
        /// <summary>
        /// Handle notofocation
        /// </summary>
        /// <param name="data">Parameter notification</param>
        void Handle(TData data);
    }
}