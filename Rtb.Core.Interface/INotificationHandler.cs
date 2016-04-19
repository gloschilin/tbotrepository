namespace Rtb.Core.Interface
{
    /// <summary>
    /// Обработчик события
    /// </summary>
    /// <typeparam name="TParam"></typeparam>
    public interface INotificationHandler<in TParam>
    {
        /// <summary>
        /// Выполняет необхоидмый действия над объектом события
        /// </summary>
        /// <param name="parameters"></param>
        void Handle(TParam parameters);
    }
}