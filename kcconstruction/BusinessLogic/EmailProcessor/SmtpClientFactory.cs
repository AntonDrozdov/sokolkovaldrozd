using System.Net.Mail;

namespace kcconstruction.BusinessLogic.EmailProcessor
{
    public class SmtpClientFactory : ISmtpClientFactory
    {
        public SmtpClient CreateSmtpClient()
        {
            return new SmtpClient();
        }
    }
}
