using System;
using System.Collections.Generic;
using System.Text;

namespace Insperon.Data.DomainModel
{
    public interface ICruRepository<TEntity, TId> : IUpdateableRepository<TEntity, TId>
        where TEntity : IEntity
    {
        void Add(TEntity entity);
        void AddRange(IList<TEntity> entity);

    }
}
