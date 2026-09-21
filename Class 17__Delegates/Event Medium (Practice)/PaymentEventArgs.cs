using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Medium__Practice_
{
    public class PaymentEventArgs : EventArgs
    {
        public int PaymentId { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }
        public PaymentEventArgs(int paymentId, string customerName, double amount) { PaymentId = paymentId; CustomerName = customerName; Amount = amount; }
    }
}
