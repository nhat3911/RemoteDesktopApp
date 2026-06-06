using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAuthApp.Helpers
{
    public static class AuthSession
    {
        public static string Uid { get; set; } = "";
        public static string Username { get; set; } = "";
        public static string Email { get; set; } = "";
        public static string DisplayName { get; set; } = "";
        public static string IdToken { get; set; } = "";
        public static string RefreshToken { get; set; } = "";
        public static DateTime LoginAt { get; set; }

        public static void Clear()
        {
            Uid = Username = Email = DisplayName = IdToken = RefreshToken = "";
            LoginAt = default;
        }
    }
}
