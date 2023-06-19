using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.RepositoryImplementation
{
    public class GenericRepository
    {
        public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : AbstractModelClass
        {


            private readonly CustomDbContext _dbContext;

            public GenericRepository(CustomDbContext dbContext)
            {
                _dbContext = dbContext;
            }
            public async Task<TEntity> GetByIdAsync(Guid Id)
            {
                try
                {
                    var result = await _dbContext.Set<TEntity>().FindAsync(Id);
                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public async Task<List<TEntity>> GetAllAsync()
            {
                try
                {
                    return await _dbContext.Set<TEntity>().ToListAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
            {
                try
                {
                    List<TEntity> entities = new();

                    if (filter != null)
                    {
                        return entities = await _dbContext.Set<TEntity>().Where(filter).ToListAsync();
                    }
                    else
                    {
                        entities = await _dbContext.Set<TEntity>().ToListAsync();
                    }

                    return await _dbContext.Set<TEntity>().ToListAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }



            /// <summary>
            /// 
            /// </summary>
            /// <param name="entity"></param>
            /// <returns cref="TEntity"></returns>
            /// <exception cref="Exception"></exception>
            public async Task<TEntity> InsertAsync(TEntity entity)
            {
                try
                {
                    var result = await _dbContext.Set<TEntity>().AddAsync(entity);
                    return result.Entity;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public TEntity Update(TEntity entity)
            {
                try
                {

                    var result = _dbContext.Set<TEntity>().Update(entity);
                    return result.Entity;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public async Task<bool> HardDeleteAsync(Guid Id)
            {
                try
                {
                    var entityToDelete = await GetByIdAsync(Id);
                    _dbContext.Set<TEntity>().Remove(entityToDelete);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }
    }
}
