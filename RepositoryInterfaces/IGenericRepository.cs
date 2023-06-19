using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryInterfaces
{
    /// <summary>
    /// Generic Repository meant to cover the basic CRUD operations as well as a GetAll and Save() function
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();
        /// <summary>
        /// This method retrieves entities from the database, applying an optional filter expression delegate,
        /// and returns a list of entities that following the filter parameters.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns >
        /// A task that represents the asynchronous operation.
        ///     The task result contains a <see cref="List{T}" /> that contains elements from the input sequence.
        /// </returns>
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> GetByIdAsync(Guid Id);
        Task<TEntity> InsertAsync(TEntity entity);
        TEntity Update(TEntity entity);
        Task<bool> HardDeleteAsync(Guid Id);
    }
}
