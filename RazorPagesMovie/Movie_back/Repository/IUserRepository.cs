using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movie_Back.Models;
namespace Movie_back.Repository
{
    public interface IUserRepository
    {
        Task AddUser(User user, string password);

    }
}
