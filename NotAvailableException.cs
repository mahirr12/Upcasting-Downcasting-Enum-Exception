using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting_Enum__Exception
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException()
        {
        }

        public NotAvailableException(string? message) : base(message)
        {
        }
    }
}
