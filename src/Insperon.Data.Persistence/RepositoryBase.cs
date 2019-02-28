using Insperon.Data.DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Insperon.Data.Persistence
{
    public abstract class RepositoryBase<TEntity, TId>
        where TEntity : EntityBase<TId>
    {
        public RepositoryBase(DbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }

        public virtual TEntity GetById(TId id)
        {
            return this.dbSet.Find(id);
        }

        public virtual TEntity FirstOrDefault()
        {
            return this.dbSet
                .OrderBy(x => x.Id)
                .FirstOrDefault();
        }

        public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return this.dbSet
                .OrderBy(x => x.Id)
                .FirstOrDefault(predicate);
        }

        public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return this.dbSet.SingleOrDefault(predicate);
        }

        public virtual void Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            this.dbSet.Add(entity);
            this.dbContext.SaveChanges();
        }

        public virtual void AddRange(IList<TEntity> entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            this.dbSet.AddRange(entity);
            this.dbContext.SaveChanges();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return this.dbSet.AsEnumerable();
        }

        public virtual void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            this.dbContext.Entry(entity).State = EntityState.Modified;
            this.dbContext.SaveChanges();
        }

        private readonly DbSet<TEntity> dbSet;
        private readonly DbContext dbContext;
    }
}
