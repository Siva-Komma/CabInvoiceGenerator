using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException
    {
        public enum ExceptionType
        {
            INVALID_RIDE_TYPR,
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDE,
            INVALID_USER_ID
        }
        ExceptionType Type;
        public CabInvoiceException(ExceptionType type,string)
        {

        }
    }
}
