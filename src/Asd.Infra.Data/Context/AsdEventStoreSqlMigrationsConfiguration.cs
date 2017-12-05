namespace Asd.Infra.Data.Context
{
    using System.Data.Entity.Migrations;

    public class AsdEventStoreSqlMigrationsConfiguration : DbMigrationsConfiguration<AsdEventStoreSqlContext>
    {
        public AsdEventStoreSqlMigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
