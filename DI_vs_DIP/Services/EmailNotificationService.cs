using DI_vs_DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_vs_DIP.Services
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            // Code to send email
            Console.WriteLine($"Sending Email: {message}");
        }
    }
}
