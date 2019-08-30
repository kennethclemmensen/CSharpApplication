using Logic;
using Logic.Exceptions;
using System;

namespace ConsoleApp {

    /// <summary>
    /// 
    /// </summary>
    class Program {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main() {
            try {
                Console.WriteLine(StringHelper.IsPalindrome("ibofobi"));
            } catch(EmptyStringException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}