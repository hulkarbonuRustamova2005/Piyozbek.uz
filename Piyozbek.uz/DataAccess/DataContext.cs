using Microsoft.EntityFrameworkCore;
using Piyozbek.uz.DataAccess.Entities;

namespace Piyozbek.uz.DataAccess
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }  
    }
}
