using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership.Models
{
    public class Users
    {
        public User currentUser { get; set; }

        public List<User> users { get; set; }
        public Users()
        {
            users = new List<User>();
        }
        public void setUser(string un)
        {
            foreach (User u in users)
            {
                if (u.username == un) currentUser = u;
            }
        }
        public void addUser(string username)
        {
            User newUser = new(username);
            foreach (User u in users)
            {
                if (u.username == username)
                {
                    setUser(username);
                    return;
                }
            }
            users.Add(newUser);
            setUser(newUser.username);
        }
        public List<User> getUsers()
        {
            return users;
        }
    }
}
