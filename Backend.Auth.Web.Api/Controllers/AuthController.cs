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
using Newtonsoft.Json.Linq;

namespace Backend.Auth.Web
{
    
 
    public class AuthController : ApiController
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            this._authService = authService;
        }

        //[HttpPost]
        //[JObjectParamValidate(Params ="userId,password")]
        //[CacheOutputWithPost(ServerTimeSpan =15)]
        //public async Task<IHttpActionResult> Login([FromBody]JObject param )
        //{
        //    try
        //    {
        //        var result = await this._authService.Login(param["userId"].Value<string>()  ,param["password"].Value<string>());
        //        return this.JsonResult(result); 
        //    }
        //    catch(Exception ex)
        //    {
        //        return this.JsonResult(ex.ToJson());
        //    }         
        //}

        [HttpPost]    
        [CacheOutputWithPost(ServerTimeSpan = 10)]
        public async Task<IHttpActionResult> Login([FromBody]LoginParam param)
        {
            try
            {
                var period = DateTimeOffset.UtcNow.AddHours(24 * 7).ToUnixTimeSeconds();
                var result = await this._authService.Login(param.UserId, param.Password,period);
                return this.JsonResult(result);
            }
            catch (Exception ex)
            {
                return this.JsonResult(ex.ToJson());
            }
        }


        [HttpPost]
        [Authentication]
        public async Task<IHttpActionResult> Logout([FromBody]JObject param)
        {
            var result = await this._authService.Logout(param["accessToken"].Value<string>());
            return this.JsonResult(result) ;
        }


    }
}