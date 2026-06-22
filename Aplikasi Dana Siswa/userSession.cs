using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Dana_Siswa
{
    public static class userSession
    {
        public static int IdUser { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Role { get; set; }

        public static bool IsAdmin()
        {
            return Role == "Administrator";
        }

        public static bool IsBendahara()
        {
            return Role == "Bendahara";
        }

        public static void Logout()
        {
            IdUser = 0;
            Username = " ";
            Password = " ";
        }
    }
}
