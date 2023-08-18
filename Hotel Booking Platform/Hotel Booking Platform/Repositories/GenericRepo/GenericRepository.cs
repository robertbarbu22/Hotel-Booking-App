using Hotel_Booking_Platform.Hotel_Booking_Platform.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DBContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DBContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _dbSet.UpdateRange(entities);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void DeleteAll()
        {
            _dbSet.RemoveRange(_dbSet);
        }

        public async Task<TEntity> FindByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public TEntity FindById(object id)
        {
            return _dbSet.Find(id);
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
