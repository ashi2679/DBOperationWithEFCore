using Microsoft.EntityFrameworkCore;

namespace DBOperationWithEFCoreApp.Data
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
            
        }
    }
}
