using DI_vs_DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_vs_DIP.Core
{
    public class NotificationManager
    {
        private readonly INotificationService _notificationService;

        // Constructor receives a notification service, which is the "injection" of the dependency
        public NotificationManager(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void Notify(string message)
        {
            _notificationService.Send(message);
        }
    }
}
