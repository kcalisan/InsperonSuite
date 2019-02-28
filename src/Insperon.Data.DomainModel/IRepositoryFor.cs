namespace Insperon.Data.DomainModel
{
    public interface IRepositoryFor<TEntity>: 
        IRepository
        where TEntity: IEntity
    {
    }
}