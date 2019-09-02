using Logic.Exceptions;

namespace Logic {

    /// <summary>
    /// The StringHelper class contains utility methods to use with strings
    /// </summary>
    public static class StringHelper {

        /// <summary>
        /// Check if the word is a palindrome
        /// </summary>
        /// <param name="word">The word to check</param>
        /// <returns>True if the word is a palindrome. False if the word isn't a palindrome</returns>
        /// <exception cref="EmptyStringException">Throws an EmptyStringException if word is empty</exception>
        public static bool IsPalindrome(string word) {
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