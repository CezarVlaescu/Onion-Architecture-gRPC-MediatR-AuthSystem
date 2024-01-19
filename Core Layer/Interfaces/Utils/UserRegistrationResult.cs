using Core_Layer.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Utils
{
    public class UserRegistrationResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public User User { get; set; }
        public string Token { get; set; }
    }
}
