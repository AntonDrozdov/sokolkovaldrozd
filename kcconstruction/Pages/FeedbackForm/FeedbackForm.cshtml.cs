using kcconstruction.BusinessLogic;
using kcconstruction.BusinessLogic.EmailProcessor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kcconstruction.Pages.FeedbackForm
{
    public class FeedbackFormModel : PageModel
    {
        private readonly  IEmailService _emailService;

        public FeedbackFormModel(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void OnPost()
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

            _emailService.Send(emailMessage);
        }
    }


}