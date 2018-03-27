﻿using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;
using QuickNetChat.DataRepository.Entitys;

namespace QuickNetChat.DataRepository
{
    public class DataContext : DbContext
    {
        /// <summary>
        ///     Event delegate for the OnAfterDataContextInitalized event.
        /// </summary>
        public delegate void AfterDataContextInitalized();

        /// <inheritdoc />
        /// <summary>
        ///     Constructor. Calls the DbContext Base function with the DataConsts.ConnectionString.
        /// </summary>
        public DataContext() : base(DataConsts.ConnectionString)
        {
        }

        // Define Db-Sets
        public DbSet<User> Users { get; set; }

        public DbSet<Channel> Channels { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Media> Media { get; set; }

        public static event AfterDataContextInitalized OnDataContextInitialized;

        /// <summary>
        ///     Function to initalize the DataContext the first time.
        /// </summary>
        internal async Task FirstInit()
        {
            Database.SetInitializer<DataContext>(null);

            // Activate automatic Table migration. 
            DbMigrationsConfiguration migrationsConfiguration = new DbMigrationsConfiguration<DataContext>
            {
                //TODO: Add compiler switch for debugging and release
                AutomaticMigrationDataLossAllowed = true,
                AutomaticMigrationsEnabled = true
            };

            // Assign database migrator and update it.
            DbMigrator dbMigrator = new DbMigrator(migrationsConfiguration);
            dbMigrator.Update();

            // Bind event and open the DataContext async.
            Database.Connection.StateChange += ConnectionOnStateChange;
            await Database.Connection.OpenAsync().ConfigureAwait(false);
        }

        /// <summary>
        ///     Called if the Database.Connection state is changed.
        /// </summary>
        /// <param name="sender">Caller object of this event.</param>
        /// <param name="stateChangeEventArgs">State changed event arguments</param>
        private void ConnectionOnStateChange(object sender, StateChangeEventArgs stateChangeEventArgs)
        {
            if (stateChangeEventArgs.CurrentState == ConnectionState.Open)
                OnOnDataContextInitialized();
        }

        /// <summary>
        ///     Called if the Data context is fully initialized.
        /// </summary>
        protected virtual void OnOnDataContextInitialized()
        {
            OnDataContextInitialized?.Invoke();
        }
    }
}