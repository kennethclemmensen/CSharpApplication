using Entity;
using System;

namespace DataAccess {

    /// <summary>
    /// The WordsAccess class contains methods to access the Words table in the database
    /// </summary>
    public class WordsAccess {

        /// <summary>
        /// Initialize a new instance of the WordsAccess class
        /// </summary>
        public WordsAccess() { }

        /// <summary>
        /// Add a word
        /// </summary>
        /// <param name="word">The word to add</param>
        /// <exception cref="Exception">Throws an Exception if adding the word to the database fails</exception>
        public void AddWord(Word word) {
            var db = new DatabaseContext();
            try {
                db.Words.Add(word);
                db.SaveChanges();
            } catch(Exception) {
                throw;
            } finally {
                db.Dispose();
            }
        }
    }
}