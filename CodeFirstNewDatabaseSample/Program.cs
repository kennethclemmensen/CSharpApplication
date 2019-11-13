using System;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public string Term { get; set; }

        public string Description { get; set; }
    }

    public class DatabaseContext : DbContext {

        public DatabaseContext() : base("DbConnection") { }

        public DbSet<Word> Words { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}