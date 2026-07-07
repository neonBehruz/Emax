using Emax.Data.DbContest;
using Emax.Data.IRepositories;
using Emax.Domain.Configuration;
using Emax.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace Emax.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
{
    private AppDbContext dbContext;
    private readonly DbSet<TEntity> dbSet;
    public Repository()
    {
        this.dbContext = new AppDbContext();
        this.dbSet = dbContext.Set<TEntity>();
    }
    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        await dbSet.AddAsync(entity);
        await dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> ModifyAsync(TEntity entity)
    {
        dbSet.Update(entity);
        await dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> RemoveAsync(long id)
    {
        var entity = await dbSet.FirstOrDefaultAsync(e => e.Id == id);
        if(entity == null) return false;
        dbSet.Remove(entity);
        await dbContext.SaveChangesAsync();
        return true;
    }

    public IQueryable<TEntity> SelectAll()
    {
        return dbSet;
    }

    public async Task<TEntity> SelectByIdAsync(long id)
    {
        return await dbSet.FirstOrDefaultAsync(e => e.Id == id);
    }
}
