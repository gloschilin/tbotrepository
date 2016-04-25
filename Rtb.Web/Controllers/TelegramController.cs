using System.Net;
using System.Web.Http;
using Rtb.Core.Interface;
using Rtb.Entity.Telegram;

namespace Rtb.Web.Controllers
{
    /// <summary>
    /// Telegram webhook
    /// </summary>
    public class TelegramController : ApiController
    {
        private readonly IConstantsContainer _constantsContainer;
        private readonly INotification<Update> _updateNotification;

        public TelegramController(IConstantsContainer constantsContainer,
            INotification<Update> updateNotification)
        {
            _constantsContainer = constantsContainer;
            _updateNotification = updateNotification;
        }

        /// <summary>
        /// Get telegram update message
        /// </summary>
        /// <param name="update"></param>
        [HttpPost]
        [Route("api/telegram/update")]
        public void Update([FromBody]Update update)
        {
            var handlers = _updateNotification.GetHandlers(update);

            foreach (var notificationHandler in handlers)
            {
                notificationHandler.Handle(update);
            }
        }
    }
}
