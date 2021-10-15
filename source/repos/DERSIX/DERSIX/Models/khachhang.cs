using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DERSIX.Models
{
    public class khachhang
    {
        private string username;
        private string email;
        private string pass;

        public khachhang()
        {
        }

        public khachhang(string username, string email, string pass)
        {
            this.Username = username;
            this.Email = email;
            this.Pass = pass;
        }

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
