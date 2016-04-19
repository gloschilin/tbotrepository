namespace Rtb.Core.Interface
{
    /// <summary>
    /// Обработчик запроса в объект события
    /// </summary>
    /// <typeparam name="TParam"></typeparam>
    public interface IRequestBuilder<out TParam>
    {
        /// <summary>
        /// получить из объекта запроса параметр события
        /// </summary>
        /// <param name="requestFromService"></param>
        /// <returns></returns>
        TParam ReadParams(RequestFromService requestFromService);
    }
}