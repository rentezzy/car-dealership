﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership.Models
{
    public class User
    {
        public string username { get; set; }
        public List<Notification> notifications { get; set; }
        public User()
        {
        }
        public User(string username)
        {
            this.username = username;
            notifications = new();
        }

        public void AddNotification(string message)
        {
            notifications.Add(new Notification(message));
        }
    }
}
