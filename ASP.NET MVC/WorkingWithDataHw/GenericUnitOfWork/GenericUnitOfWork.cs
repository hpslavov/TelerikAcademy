using GenericUnitOfWork.Contracts;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterLike.Data;
using TwitterLike.Data.Contracts;
using TwitterLike.Data.Repositories;

namespace TwitterLike.UnitOfWork
{
    public class GenericUnitOfWork<TContext>: IGenericUnitOfWork<TContext> where TContext : TwitterLikeDbContext, new()    
    {
        private TwitterLikeDbContext ctx;
        private Dictionary<Type, object> repositories;

        public GenericUnitOfWork()
        {
            ctx = new TwitterLikeDbContext();
            repositories = new Dictionary<Type, object>();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (repositories.Keys.Contains(typeof(TEntity)))
                return repositories[typeof(TEntity)] as IRepository<TEntity>;

            var repository = new EfGenericRepository<TEntity>(ctx);
            repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public void Save()
        {
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
