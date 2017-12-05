namespace Asd.Infra.Data.Context
{
    using System.Data.Entity;

    public abstract class AsdSqlContext : DbContext
    {
        public AsdSqlContext(string connectionString) : base(connectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AsdSqlContext, AsdSqlMigrationsConfiguration>(true));
            base.OnModelCreating(modelBuilder);
        }
    }
}
