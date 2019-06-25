using Microcomm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 

namespace Backend.Auth.Service
{
    public interface IAuthService: Microcomm.Security.ITokenIdentify
    {
        Task<JsonResultData<LoginResult>> Login(string userId ,string password, long expirePeriodSeconds);

        Task<JsonResultData<bool>> Logout(string accessToken);

 
    }
}
