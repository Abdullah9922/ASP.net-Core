namespace Demo.Web.Code
{
    public interface IEmailSender
    {
        void SendEmail(string to, string subject, string body);
    }
}
