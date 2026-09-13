using System;
using System.Collections.Generic;
using System.Text;

namespace Notification_System
{
    public class SmsNotification : Notification
    {
        public SmsNotification(string massage) : base(massage) { }

        public override void Send()
        {
            Console.WriteLine($"Sending SMS: {Message}");
        }
    }
}
