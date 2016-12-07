using System;

namespace Travel_Agency
{
    class WrongDataFileException : Exception
    {
        public WrongDataFileException()
        {
        }

        public WrongDataFileException(string message) : base(message)
        {
        }

        public WrongDataFileException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
