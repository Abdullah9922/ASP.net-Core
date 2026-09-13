using System;
using System.Collections.Generic;
using System.Text;

namespace Notification_System
{
    internal class PushNotification : Notification
    {
        public PushNotification(string massage) : base(massage) { }

        public override void Send()
        {
            Console.WriteLine($"Sending SMS: {Message}");
        }
    }
}
