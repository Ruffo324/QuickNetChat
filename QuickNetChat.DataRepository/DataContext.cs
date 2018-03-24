using System.Data.Entity;
using System.Data.Entity.Migrations;
using QuickNetChat.DataRepository.Entitys;

namespace QuickNetChat.DataRepository
{
    public class DataContext : DbContext
    {
        public DataContext() : base(DataConsts.ConnectionString)
        {
        }

        // Define Db-Sets
        public DbSet<User> Users { get; set; }

        public DbSet<Channel> Channels { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Media> Media { get; set; }

        internal void FirstInit()
        {
            Database.SetInitializer<DataContext>(null);

            // Activate automatic Table migration. 
            DbMigrationsConfiguration migrationsConfiguration = new DbMigrationsConfiguration<DataContext>
            {
                //TODO: Add compiler switch for debugging and release
                AutomaticMigrationDataLossAllowed = true,
                AutomaticMigrationsEnabled = true
            };

            DbMigrator dbMigrator = new DbMigrator(migrationsConfiguration);
            dbMigrator.Update();

            Database.Connection.Open();
        }
    }
}