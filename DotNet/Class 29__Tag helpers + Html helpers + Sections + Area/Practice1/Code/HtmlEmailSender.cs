namespace Practice1.Code
{
    public class HtmlEmailSender : IEmailSender
    {
        public void SendMail(string emailId, string main)
        {
            Console.WriteLine("HTML Email Sent!");
            Console.WriteLine(emailId);
            Console.WriteLine(main);
        }
    }
    
}
