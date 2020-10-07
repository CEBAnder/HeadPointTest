using System;
using System.Collections.Generic;
using System.Text;

namespace HeadPointTest.Task2
{
    public class IncorrectParamException : Exception
    {
        public IncorrectParamException(string paramName) : base($"{paramName} must be a positive value!")
        {            
        }
    }
}
