using kcconstruction.BusinessLogic.Models.EmailService;

namespace kcconstruction.BusinessLogic.Interfaces.EmailService
{
    public interface IEmailService
    {
        bool Send(Message message);
    }
}
