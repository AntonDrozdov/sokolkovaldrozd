using System;
using System.Collections.Generic;
using System.Text;

namespace kcconstruction.BusinessLogic.Models.AppSettings
{
    public class CustomKCSettings
    {
        public string Value { get; set; }

        public EmailServiceSettings EmailServiceSettings { get; set; }
    }
}
