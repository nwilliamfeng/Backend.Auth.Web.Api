using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Backend.Auth.Data
{
    public interface IUserRepository
    {
        Task<User> Load(string nickName,string password);

        Task<User> AddOrUpdate(User user);

        bool IsCache { get; }

    }
}
