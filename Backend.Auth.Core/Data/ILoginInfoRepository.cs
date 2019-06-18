using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Backend.Auth.Data
{
    public interface ILoginInfoRepository  
    {
        Task<int> GetLoginTimeStamp(string userId);

        bool IsCache { get; }

        Task<bool> Update(string userId,DateTime time);
    }
}
