using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.BusinessLogic;
using kcconstruction.BusinessLogic.EmailProcessor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages
{
    public class ContactsModel : PageModel
    {
        [BindProperty]
        public EmailMessageModel EmailMessage { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostSendEmail()
        {
            EmailSender emailSender = new EmailSender();
            emailSender.Send(new Message
            {
                Body = "blabla",
                Subject = "sublject"
            });

            return RedirectToPage("/Contacts");
        }
        
        public class EmailMessageModel
        {
            public string Name { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }

            public string Message { get; set; }
        }
    }
}