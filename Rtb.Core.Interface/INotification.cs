using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rtb.Core.Interface
{
    /// <summary>
    /// Уведомление о событии
    /// </summary>
    public interface INotification<in TParam>
    {
        /// <summary>
        /// получить обработчиков события
        /// </summary>
        /// <param name="requestFromService">объект запроса события</param>
        /// <returns>коллекция обработчиков события</returns>
        IEnumerable<INotificationHandler<TParam>> GetHendlers(RequestFromService requestFromService);
    }
}
