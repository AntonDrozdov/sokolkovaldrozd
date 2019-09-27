using System;
using System.Net.Mail;
using kcconstruction.BusinessLogic.Interfaces.EmailService;
using kcconstruction.BusinessLogic.Models.AppSettings;
using kcconstruction.BusinessLogic.Models.EmailService;
using Microsoft.Extensions.Options;


namespace kcconstruction.BusinessLogic.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private ISmtpClientFactory _smtpClientFactory;
        private SmtpClient SmptClient { get; }

        private CustomKCSettings _customKcSettings;

        public EmailService(ISmtpClientFactory smtpClientFactory, IOptionsMonitor<CustomKCSettings> optionsMonitor )
        {
            _smtpClientFactory = smtpClientFactory;
            SmptClient = _smtpClientFactory.CreateSmtpClient();

            _customKcSettings = optionsMonitor.CurrentValue;

        }

        public bool Send(Message message)
        {
            {
                try
                {
                    using (MailMessage mailMessage = CreateMailMessage(message))
                    {
                        SmptClient.Send(mailMessage);
                    }

                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;
            }
        }
        private MailMessage CreateMailMessage(Message message)
        {
            return CreateMailMessage(message.Subject, message.Body);
        }

        private MailMessage CreateMailMessage(string subject, string body)
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(_customKcSettings.EmailServiceSettings.MailFrom);

            foreach (var mailTo in _customKcSettings.EmailServiceSettings.MailTo)
            {
                mail.To.Add(new MailAddress(mailTo));
            }

            mail.Subject = subject;
            mail.Body = body;

            return mail;
        }
    }
}
