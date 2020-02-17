using System;

namespace CatchWhen
{
    public class InvalidEmailException
        : Exception
    {
        public InvalidEmailException(string message)
            : base(message)
        {}

        public int Severity { get; set; }
    }
}
