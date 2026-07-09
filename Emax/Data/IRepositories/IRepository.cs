using Emax.Domain.Configuration;

namespace Emax.Data.IRepositories;

public interface IRepository<TEntity>
{
    Task<TEntity> InsertAsync(TEntity entity);
    Task<TEntity> ModifyAsync(TEntity entity);
    Task<bool> RemoveAsync(Guid id);
    Task<TEntity> SelectByIdAsync(Guid id);
    IQueryable<TEntity> RetrieveAll();
}
