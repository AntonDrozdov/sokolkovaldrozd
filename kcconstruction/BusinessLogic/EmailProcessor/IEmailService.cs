using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.BusinessLogic.EmailProcessor;

namespace kcconstruction.BusinessLogic
{
    interface IEmailService
    {
        bool Send(Message message);

    }
}
