﻿namespace MedCenter_API_CSharp.Data.Repositories
{
    public interface IEntityRepository<T> where T : class
    {

        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);

    }
}
