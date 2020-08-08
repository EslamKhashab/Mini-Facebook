namespace DQ.Shared.Helper.MailService
{
    public interface IEmailSender
    {
        bool SendEmail(Message message);
    }
}
