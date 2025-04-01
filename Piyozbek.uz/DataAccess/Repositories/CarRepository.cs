using Microsoft.EntityFrameworkCore;
using Piyozbek.uz.DataAccess.Entities;
namespace Piyozbek.uz.DataAccess.Repositories
{
    public interface ICarRepository
    {
        Task Add(Car car);
        Task<Car> GetById(int id);
        Task<IList<Car>> GetAll();
        void SaveChanges();
        Task SaveChangesAsync();
    }

    public class CarRepository(DataContext context) : ICarRepository
    {
        public async Task Add(Car car)
        {
            await context.Cars.AddAsync(car);
        }

        public async Task<Car> GetById(int id)
        {
            return await context.Cars.FindAsync(id);
        }

        public async Task<IList<Car>> GetAll()
        {
            return await context.Cars.ToListAsync();
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
