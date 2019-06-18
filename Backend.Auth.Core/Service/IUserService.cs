using Microcomm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Auth.Service
{
    public interface IUserService
    {
        Task<JsonResultData<User>> Load(string userId,string password);

        Task<JsonResultData<User>> AddOrUpdate(User user);
    }
}
