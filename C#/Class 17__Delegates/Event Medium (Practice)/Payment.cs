using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Medium__Practice_
{
    public delegate void PaymentHandler(object? sender, PaymentEventArgs e);
    public class Payment
    {
        public event PaymentHandler? PaymentCompleted;
        public void MakePayment(int paymentId, string customerName, double amount)
        {
            Console.WriteLine($"Payment ID: {paymentId}"); 
            Console.WriteLine($"Customer: {customerName}"); 
            Console.WriteLine($"Amount: {amount}");

            // Event-এর data তৈরি
            PaymentEventArgs args = new PaymentEventArgs(paymentId, customerName, amount); 
            // Event trigger
            PaymentCompleted?.Invoke(this, args);
        }
    }
}
