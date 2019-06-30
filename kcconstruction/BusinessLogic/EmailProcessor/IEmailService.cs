using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kcconstruction.BusinessLogic.EmailProcessor;

namespace kcconstruction.BusinessLogic
{
    public interface IEmailService
    {
        bool Send(Message message);

    }
}
