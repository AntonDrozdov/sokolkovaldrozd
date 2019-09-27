using System;
using System.Collections.Generic;
using System.Text;

namespace kcconstruction.BusinessLogic.Models.AppSettings
{
    public class EmailServiceSettings
    {
        public EmailServiceSettings()
        {
            MailTo = new List<string>();
        }

        public string MailFrom { get; set; }

        public List<string> MailTo { get; set; }
    }
}
