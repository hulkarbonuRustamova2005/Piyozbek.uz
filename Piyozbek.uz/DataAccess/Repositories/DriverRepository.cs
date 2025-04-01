using Microsoft.EntityFrameworkCore;
using Piyozbek.uz.DataAccess.Entities;

namespace Piyozbek.uz.DataAccess.Repositories
{
    public interface IDriverRepository
    {
        Task Add(Driver driver);
        Task<Driver> GetById(int id);
        Task<IList<Driver>> GetAll();
      
        void SaveChanges();
        Task SaveChangesAsync();
    }
    public class DriverRepository (DataContext context) : IDriverRepository 
    {
        public async Task Add(Driver driver)
        {
            await context.Drivers.AddAsync(driver);
        }

        public async Task<Driver> GetById(int id)
        {
            return await context.Drivers.FindAsync(id);
        }

        public async Task<IList<Driver>> GetAll()
        {
            return await context.Drivers.ToListAsync();
        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
