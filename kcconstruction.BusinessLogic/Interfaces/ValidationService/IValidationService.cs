using System;
using System.Collections.Generic;
using System.Text;

namespace kcconstruction.BusinessLogic.Interfaces.ValidationService
{
    public interface IValidationService
    {
        bool ValidateFeedbackForm(string name, string email, string phone, string message);

    }
}
