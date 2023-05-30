using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership.Models
{
    internal class User
    {
        public string username;
        private List<Notification> notifications { get; }
        public User()
        {
        }
        public User(string username)
        {
            this.username = username;
            notifications = new();
        }

    }
}
