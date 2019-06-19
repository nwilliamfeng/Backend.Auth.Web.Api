using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Auth
{
    public class LoginParam
    {
        public string UserId { get; set; }

        public string Password { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is LoginParam))
                return false;
            var other = obj as LoginParam;
            if (this.UserId != other.UserId)
                return false;
            return this.Password == other.Password;
        }

        public override int GetHashCode()
        {
            if (this.UserId == null || this.Password == null)
                return base.GetHashCode();
            return this.UserId.GetHashCode()*37+this.Password.GetHashCode();
        }
    }
}
