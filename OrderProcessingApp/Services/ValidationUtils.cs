using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Services
{
    public class ValidationUtils
    {
        public static bool IsInteger(string candidate)
        {
            return int.TryParse(candidate, out int parsedNumber);
        }

        public static bool IsDouble(string candidate)
        {
            return double.TryParse(candidate, out double parsedNumber);
        }

        public static bool IsBlank(string candidate)
        {
            return candidate == null || candidate.Trim().Length == 0;
        }
    }
}
