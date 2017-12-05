namespace Asd.Infra.Data.Context
{
    using System.Data.Entity.Migrations;

    public class AsdSqlMigrationsConfiguration : DbMigrationsConfiguration<AsdSqlContext>
    {
        public AsdSqlMigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
