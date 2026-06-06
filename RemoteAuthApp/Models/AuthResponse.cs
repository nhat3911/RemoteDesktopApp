using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAuthApp.Models
{
    public class AuthResponse
    {
        public string localId { get; set; } = "";
        public string email { get; set; } = "";
        public string displayName { get; set; } = "";
        public string idToken { get; set; } = "";
        public string refreshToken { get; set; } = "";
    }
}
