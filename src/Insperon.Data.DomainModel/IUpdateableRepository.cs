using System;
using System.Collections.Generic;
using System.Text;

namespace Insperon.Data.DomainModel
{
    public interface IUpdateableRepository<TEntity, TId> : IReadOnlyRepository<TEntity, TId>
        where TEntity : IEntity
    {
        void Update(TEntity entity);
    }
}
