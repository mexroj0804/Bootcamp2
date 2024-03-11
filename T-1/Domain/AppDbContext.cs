using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace T_1.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppContext> options) 
            : base(options)
        {
            //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            Database.Migrate();
        }


    }
}
