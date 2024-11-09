using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Credentials
    {
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string IsTech {  get; set; }

        

        public Credentials(string email, string password, string name, string isTech)
        {
            EmailID = email;
            Password = password;
            Name = name;
            IsTech = isTech;
        }
    }
}
