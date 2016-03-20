namespace GenericUnitOfWork.Contracts
{
    using TwitterLike.Data;
    using TwitterLike.Data.Contracts;

    public interface IGenericUnitOfWork<TContext> where TContext : TwitterLikeDbContext
    {
        void Save();
        void Dispose();
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}
