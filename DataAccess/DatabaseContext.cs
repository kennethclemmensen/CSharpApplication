using System.Data.Entity;

namespace DataAccess {

    /// <summary>
    /// The DatabaseContext represents a session to the database to query and save data
    /// </summary>
    public class DatabaseContext : DbContext {

        /// <summary>
        /// Initialize a new instance of the DatabaseContext class
        /// </summary>
        public DatabaseContext() : base("DbConnection") { }

        /// <summary>
        /// Represents the Words table in the database
        /// </summary>
        public DbSet<Word> Words { get; set; }

        /// <summary>
        /// Override the OnModelCreating method with the modelBuilder
        /// to make changes to the model
        /// </summary>
        /// <param name="modelBuilder">The model builder</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}