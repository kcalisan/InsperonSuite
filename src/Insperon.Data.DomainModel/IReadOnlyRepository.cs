using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Insperon.Data.DomainModel
{
    public interface IReadOnlyRepository<TEntity,TId> : IRepositoryFor<TEntity>
        where TEntity : IEntity
    {
        TEntity GetById(TId id);

        IEnumerable<TEntity> GetAll();

        TEntity FirstOrDefault();

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
    }
}
