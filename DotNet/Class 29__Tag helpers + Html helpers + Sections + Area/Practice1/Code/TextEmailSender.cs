namespace Practice1.Code
{
    public class TextEmailSender : IEmailSender
    {
        public void SendMail(string emailId, string main)
        {
            Console.WriteLine("Text Email Sent!");
            Console.WriteLine(emailId);
            Console.WriteLine(main);
            //throw new NotImplementedException();
        }
    }

}
