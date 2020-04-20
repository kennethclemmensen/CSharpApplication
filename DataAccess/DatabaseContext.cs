using Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess {

    /// <summary>
    /// The DatabaseContext represents a session to the database to query and save data
    /// </summary>
    public class DatabaseContext : DbContext {

        /// <summary>
        /// Initialize a new instance of the DatabaseContext class
        /// </summary>
        public DatabaseContext() { }

        /// <summary>
        /// Represents the Words table in the database
        /// </summary>
        public DbSet<Word> Words { get; set; }

        /// <summary>
        /// Represents the Users table in the database
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Configure the database using the options builder
        /// </summary>
        /// <param name="optionsBuilder">The options builder</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=CSharpApplication; Integrated Security=True");
        }
    }
}