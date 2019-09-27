using System.Text.RegularExpressions;
using kcconstruction.BusinessLogic.Interfaces;
using kcconstruction.BusinessLogic.Interfaces.EmailService;
using kcconstruction.BusinessLogic.Interfaces.ValidationService;
using kcconstruction.BusinessLogic.Models.EmailService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages.FeedbackForm
{
    public class FeedbackFormModel : PageModel
    {
        private readonly IEmailService _emailService;
        private readonly IValidationService _validationService;

        public FeedbackFormModel(IEmailService emailService, IValidationService validationService)
        {
            _emailService = emailService;
            _validationService = validationService;
        }

        public IActionResult OnPost()
        {
            var Name = Request.Form["Name"].ToString();
            var Email = Request.Form["Email"].ToString();
            var Phone = Request.Form["Phone"].ToString();
            var Message = Request.Form["Message"].ToString();

            if (!_validationService.ValidateFeedbackForm(Name, Email, Phone, Message))
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
            return new JsonResult(new {status = "fail"});

        }
    }
}