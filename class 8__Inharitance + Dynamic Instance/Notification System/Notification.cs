using System;
using System.Collections.Generic;
using System.Text;

namespace Notification_System
{
    public class Notification
    {
        public string Message { get; protected set; }

        public Notification(string message)
        {
            Message = message;
        }

        public virtual void Send() { }
    }
}
