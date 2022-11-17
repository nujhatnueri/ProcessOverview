
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ProcessOverview.Domain.Interfaces;
using ProcessOverview.Domain.Models;
using ProcessOverview.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ProcessOverview.Infrastructure.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly ProcessOverviewDbContext Db;

        protected readonly DbSet<TEntity> DbSet;

        protected Repository(ProcessOverviewDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }        

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
