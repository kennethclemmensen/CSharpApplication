using DataAccess;
using Entity;
using System;

namespace Logic {

    /// <summary>
    /// The WordLogic class contains methods to handle the word logic
    /// </summary>
    public class WordLogic {

        /// <summary>
        /// Add a word
        /// </summary>
        /// <param name="word">The word to add</param>
        /// <exception cref="Exception">Throws an Exception if adding the word fails</exception>
        public void AddWord(Word word) {
            var wordAccess = new WordsAccess();
            try {
                wordAccess.AddWord(word);
            } catch(Exception) {
                throw;
            }
        }
    }
}