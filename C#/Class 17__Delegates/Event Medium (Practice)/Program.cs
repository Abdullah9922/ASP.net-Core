
using Event_Medium__Practice_;

Payment payment = new Payment();

payment.PaymentCompleted += (sender, e) => 
{
    Console.WriteLine("Sender:");
    Console.WriteLine(sender);

    Console.Write("\nSender Type:");
    Console.WriteLine(sender?.GetType().Name);

    Console.WriteLine("\nPayment completed!"); 
    Console.WriteLine($"Payment ID: {e.PaymentId}"); 
    Console.WriteLine($"Customer: {e.CustomerName}"); 
    Console.WriteLine($"Amount: {e.Amount}"); 
};

payment.MakePayment(501, "Asif", 3000);

