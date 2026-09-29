using System;
using System.Collections.Generic;
using System.Text;

namespace Notification_System
{
    public class NotificationFactory
    {
        public Notification MakeNoty(string choice, string message)
        {
            if(choice == "email") return new EmailNotification(message);
            else if(choice == "sms") return new EmailNotification(message);
            else return new PushNotification (message);
        }
    }
}
