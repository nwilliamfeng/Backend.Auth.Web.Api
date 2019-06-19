using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Backend.Auth.Service;
using Microcomm;
using Microcomm.Web.Http;
using Microcomm.Web.Http.Filters;
using WebApi.OutputCache.V2;

namespace Backend.Auth.Web.Internal
{
    
 
    public class InnerAuthController : ApiController
    {
        private IAuthService _authService;

        public InnerAuthController(IAuthService authService)
        {
            this._authService = authService;
        }

       

        [HttpGet]    
        [CacheOutput(ServerTimeSpan = 3)]
        [Authentication]
        public  Task<IHttpActionResult> Vertify()
        {
            return Task.Run(()=> this.JsonResult( true.ToJsonResultData()));
        }


        

    }
}