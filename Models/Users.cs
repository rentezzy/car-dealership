using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership.Models
{
    internal class Users
    {
        public User currentUser { get; set; }

        public List<User> users { get; set; }
        public Users() { 
        users = new List<User>();

        }
        public void setUser(string un)
        {
            foreach(User u in users)
            {
                if(u.username == un) currentUser = u;
            }
        }
        public void addUser(string username)
        {
            users.Add(new User(username));
        }
    }
}
