using System;
using System.Collections.Generic;
using System.Text;

namespace Insperon.Data.DomainModel
{
    public class EntityBase<TId> : IEntity
    {
        public TId Id { get; protected set; }
    }
}
