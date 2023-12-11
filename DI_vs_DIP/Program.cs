using DI_vs_DIP.Core;
using DI_vs_DIP.Interfaces;
using DI_vs_DIP.Services;

namespace DI_vs_DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dependency injection using constructor injection
            INotificationService emailService = new EmailNotificationService();
            NotificationManager notificationManager = new NotificationManager(emailService);

            // Send notification
            notificationManager.Notify("Hello, this is an email notification!");

            // You can swap out the dependency to use a different notification service
            INotificationService smsService = new SmsNotificationService();
            notificationManager = new NotificationManager(smsService);

            // Send another notification
            notificationManager.Notify("Hello, this is an SMS notification!");
        }
    }
}
