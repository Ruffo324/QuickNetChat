using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickNetChat.DataRepository.Entitys;

namespace QuickNetChat.DataRepository
{
    public class DataContext : DbContext
    {
        // Define Db-Sets
        public DbSet<User> Users { get; set; }

        public DbSet<Channel> Channels { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Media> Media { get; set; }


        public DataContext() : base(DataConsts.ConnectionString)
        {
        }

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