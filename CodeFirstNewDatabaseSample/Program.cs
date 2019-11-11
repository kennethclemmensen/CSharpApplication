using System;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstNewDatabaseSample {

    class Program {

        static void Main(string[] args) {
            using(var db = new DatabaseContext()) {
                Console.WriteLine("Enter a word: ");
                var term = Console.ReadLine();
                var word = new Word { Term = term };
                db.Words.Add(word);
                db.SaveChanges();
                var query = from w in db.Words
                            orderby w.Term
                            select w;
                Console.WriteLine("All words in the database:");
                foreach(var item in query) {
                    Console.WriteLine(item.Term);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class Word {

        public int Id { get; set; }

        public string Term { get; set; }
    }

    public class DatabaseContext : DbContext {

        public DbSet<Word> Words { get; set; }
    }
}