using System;

namespace Logic.Exceptions {

    /// <summary>
    /// The EmptyStringException should be thrown if a string is empty
    /// </summary>
    public class EmptyStringException : Exception {

        /// <summary>
        /// Initializes a new instance of the EmptyStringException
        /// </summary>
        public EmptyStringException() : base() { }

        /// <summary>
        /// Initializes a new instance of the EmptyStringException with a message
        /// </summary>
        /// <param name="message">The message</param>
        public EmptyStringException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the EmptyStringException with a message and an inner exception
        /// </summary>
        /// <param name="message">The message</param>
        /// <param name="innerException">The inner exception</param>
        public EmptyStringException(string message, Exception innerException) : base(message, innerException) { }
    }
}