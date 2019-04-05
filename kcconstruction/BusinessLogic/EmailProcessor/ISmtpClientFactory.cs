using System.Net.Mail;

namespace kcconstruction.BusinessLogic.EmailProcessor
{
    public interface ISmtpClientFactory
    {
        SmtpClient CreateSmtpClient();
    }
}
