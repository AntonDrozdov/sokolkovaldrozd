using System.Net.Mail;

namespace kcconstruction.BusinessLogic.Interfaces.EmailService
{
    public interface ISmtpClientFactory
    {
        SmtpClient CreateSmtpClient();
    }
}
