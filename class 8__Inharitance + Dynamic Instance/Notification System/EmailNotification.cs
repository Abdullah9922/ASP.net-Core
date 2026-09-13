using System;
using System.Collections.Generic;
using System.Text;

namespace Notification_System
{
    public class EmailNotification : Notification
    {
        public EmailNotification(string message) : base(message) { }

        public override void Send()
        {
            Console.WriteLine($"Sending Email: {Message}");
        }
    }
}
