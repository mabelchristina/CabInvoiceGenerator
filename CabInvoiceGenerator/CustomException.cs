using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public enum ExceptionType
    {
        NULL_EXCEPTION
    }
    public class CustomException : Exception
    {
        public string message;

        public CustomException(string Message)
        {
            this.message = Message;
        }
    }
}
