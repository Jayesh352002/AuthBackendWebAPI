using CRUDAPITest.Model;
using Microsoft.EntityFrameworkCore;
namespace CRUDAPITest.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
