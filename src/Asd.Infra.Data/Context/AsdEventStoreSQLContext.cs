namespace Asd.Infra.Data.Context
{
    using Asd.Domain.Core.Events;
    using System;
    using System.Data.Entity;

    public class AsdEventStoreSqlContext : DbContext
    {
        public DbSet<AsdStoredEvent> StoredEvents { get; set; }

        public AsdEventStoreSqlContext(string connectionString) : base(connectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AsdEventStoreSqlContext, AsdEventStoreSqlMigrationsConfiguration>(true));
            base.OnModelCreating(modelBuilder);
        }
    }
}
