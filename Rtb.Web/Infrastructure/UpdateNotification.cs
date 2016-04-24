using System.Collections.Generic;
using Rtb.Entity.Telegram;
using Rtb.Web.Controllers;

namespace Rtb.Web.Infrastructure
{
    /// <summary>
    /// Notification received where telegram send update command to bot
    /// </summary>
    public class UpdateNotification:INotification<Update>
    {
        private readonly IEnumerable<INotificationHandler<Update>> _updateHandlers;

        public string Alias => "update";

        public string Description => "Notification received where telegram send update command to bot";

        public UpdateNotification(IEnumerable<INotificationHandler<Update>> updateHandlers)
        {
            _updateHandlers = updateHandlers;
        }
        
        public IEnumerable<INotificationHandler<Update>> GetHandlers(Update data)
        {
            return _updateHandlers;
        }
    }
}