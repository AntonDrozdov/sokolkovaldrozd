using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using kcconstruction.BusinessLogic.EmailProcessor;
using Microsoft.Extensions.Logging;

namespace kcconstruction.BusinessLogic
{
    public class EmailSender : IEmailService
    {
        private SmtpClient SmptClient { get; }

        public EmailSender()
        {
            ISmtpClientFactory smtpClienFactory = new SmtpClientFactory();
            SmptClient = smtpClienFactory.CreateSmtpClient();
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
            return new MailMessage(new MailAddress("kc-construction.ru"), new MailAddress("info@kc-construction.ru"))
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };
        }
    }
}
