﻿using System.Net;
using System.Net.Mail;

namespace kcconstruction.BusinessLogic.EmailProcessor
{
    public class SmtpClientFactory : ISmtpClientFactory
    {
        public SmtpClient CreateSmtpClient()
        {

            var smtpClient = new SmtpClient();

            var credential = new NetworkCredential
            {
                UserName = "kcconstruction2018@yandex.ru",
                Password = "kc_construction_2018"
            };
            smtpClient.Credentials = credential;
            smtpClient.Host = "smtp.yandex.ru";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            
            return smtpClient;
        }
    }
}
