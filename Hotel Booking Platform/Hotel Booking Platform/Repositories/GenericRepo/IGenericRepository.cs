﻿namespace Hotel_Booking_Platform.Hotel_Booking_Platform.Repositories.GenericRepo
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();
        Task CreateAsync(TEntity entity);
        Task CreateRangeAsync(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

        void DeleteAll();

        Task<TEntity> FindByIdAsync(object id);
        TEntity FindById(object id);

        Task<bool> SaveAsync();
        bool Save();
    }
}
