using System;
using ClassLibrary.Enums;

namespace ClassLibrary.Exceptions
{
    public class CustomException : Exception
    {
        public AppMessage Reason { get; private set; }

        public CustomException(AppMessage message) : base(message.GetDescription())
        {
            Reason = message;
        }
    }
}