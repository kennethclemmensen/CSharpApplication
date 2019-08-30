using System;

namespace Logic.Exceptions {

    /// <summary>
    /// 
    /// </summary>
    public class EmptyStringException : Exception {

        /// <summary>
        /// 
        /// </summary>
        public EmptyStringException() : base() {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public EmptyStringException(string message) : base(message) {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public EmptyStringException(string message, Exception innerException) : base(message, innerException) {

        }
    }
}