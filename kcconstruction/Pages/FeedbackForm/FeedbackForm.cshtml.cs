using System;
using System.Net;
using System.Text.RegularExpressions;
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

            if (!validateFeedbackForm(Name, Email, Phone, Message))
            {
                return new JsonResult(new { status = "fail" });
            }

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
                return new JsonResult(new {status = "success"});
            }
            else
            {
                return new JsonResult(new {status = "fail"});
            }
            
        }

        private bool validateFeedbackForm(string name, string email, string phone, string message)
        {
            var nameValid = name.Length >= 2;

            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            var emailValid = Regex.Match(email, pattern, RegexOptions.IgnoreCase).Success;
            
            pattern = "^[0-9]{3, 10}$";
            var telephonValid = Regex.Match(email, pattern, RegexOptions.IgnoreCase).Success;

            var messageValid = message.Length >= 10 && message.Length <= 3000;

            return nameValid && emailValid && telephonValid && messageValid;


        }
    }
}