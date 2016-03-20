using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterLike.Data.Models;

namespace TwitterLike.Services.Contracts
{
    public interface IUserService
    {
        IQueryable<User> GetAllUsers();
        User GetUserByName(string name);
    }
}
