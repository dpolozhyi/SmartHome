using System.Data.Entity;

namespace SmartHome.DAL.DBContext
{
    public class EFContextInitializer : CreateDatabaseIfNotExists<EFContext>
    {
        protected override void Seed(EFContext context)
        {
        }
    }
}
