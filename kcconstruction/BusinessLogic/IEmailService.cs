using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kcconstruction.BusinessLogic
{
    interface IEmailService
    {
        void Send(string text);
    }
}
