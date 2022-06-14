using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblems
{
    public class CustomExceptions : Exception
    {
        public enum ExceptionType
        {
            INVALID_NAME, INVALID_EMAIL, INVALID_NUMBER, INVALID_PASSWORD
        }
        ExceptionType type;
        public CustomExceptions(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
