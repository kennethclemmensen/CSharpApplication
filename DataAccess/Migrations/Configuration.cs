using System.Data.Entity.Migrations;

namespace DataAccess.Migrations {

    /// <summary>
    /// The Configuration class contains the settings 
    /// to use when new migrations are added
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext> {

        /// <summary>
        /// Initialize a new instance of the Configuration class
        /// and setup the migration settings
        /// </summary>
        public Configuration() {
            AutomaticMigrationsEnabled = true;
        }

        /// <summary>
        /// Add seed data to the database by using the DatabaseContext
        /// </summary>
        /// <param name="context">The DatabaseContext</param>
        protected override void Seed(DatabaseContext context) {

        }
    }
}