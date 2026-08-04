

using Notification_System;

Console.Write("Enter your choice: ");
string choice = Console.ReadLine();

// try to make the system dynamic massage output
Notification n = new NotificationFactory().MakeNoty(choice, "Welcome to our application!");
n.Send();

