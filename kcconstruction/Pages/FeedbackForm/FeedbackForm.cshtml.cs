using System;
using System.Net;
using kcconstruction.BusinessLogic;
using kcconstruction.BusinessLogic.EmailProcessor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace kcconstruction.Pages.FeedbackForm
{
    public class FeedbackFormModel : PageModel
    {
        private readonly  IEmailService _emailService;

        public FeedbackFormModel(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public IActionResult OnPost()
        {
            var Name = Request.Form["Name"].ToString();
            var Email = Request.Form["Email"].ToString();
            var Phone = Request.Form["Phone"].ToString();
            var Message = Request.Form["Message"].ToString();

            var emailMessage = new Message
            {
                Subject = "Запрос с сайта kc-construction.ru",
                Body = $"ОТ: {Name}\n\n" +
                       $"E-mail:{Email}\n\n" +
                       $"ТЕЛЕФОН:{Phone}\n\n" +
                       $"СООБЩЕНИЕ:\n\n" +
                       $"{Message}"

            };

            if (_emailService.Send(emailMessage))
            {
                return new JsonResult(new { status = "success" });
            }
            else
            {
                return new JsonResult(new { status = "fail" });
            }

        }
    }
}