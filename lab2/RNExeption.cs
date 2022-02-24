using System;

namespace HW_2
{
    internal class RomanNumberException : Exception
    {
        public RomanNumberException() : base() { }
        public RomanNumberException(string message) : base(message) { }
    }
}