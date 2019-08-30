using Logic.Exceptions;
using System;

namespace Logic {

    /// <summary>
    /// 
    /// </summary>
    public class StringHelper {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        /// <exception cref="EmptyStringException"></exception>
        public static Boolean IsPalindrome(string word) {
            if(word == "") {
                throw new EmptyStringException("Word is empty");
            } else if(word.Length == 1) {
                return true;
            } else {
                int leftIdx = 0;
                int rightIdx = word.Length - 1;
                while(leftIdx < rightIdx) {
                    if(word[leftIdx] != word[rightIdx]) return false;
                    leftIdx++;
                    rightIdx--;
                }
                return true;
            }
        }
    }
}