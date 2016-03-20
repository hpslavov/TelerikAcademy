namespace TwitterLike.Services
{
    using Contracts;
    using Data;
    using Data.Contracts;
    using Data.Models;
    using Data.Repositories;
    using GenericUnitOfWork.Contracts;
    using System.Collections.Generic;
    using System.Linq;
    using TwitterLike.Services;
    using TwitterLike.UnitOfWork;
    public class UserService :IUserService
    {
        private IGenericUnitOfWork<TwitterLikeDbContext> unitOfWork;
        private IRepository<User> users;

        public UserService(IGenericUnitOfWork<TwitterLikeDbContext> uow)
        {
            unitOfWork = uow;
            users = unitOfWork.GetRepository<User>();
        }

        public IQueryable<User> GetAllUsers()
        {
            return users.All();
        }   

        public User GetUserByName(string name)
        {
            var userFromDb = users.All().Where(u => u.UserName == name).First();

            return userFromDb;
        }

    }
}
