using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership.Models
{
    public class Notification
    {
        public string message { get;set; }
        public Notification()
        {
        }
        public Notification(string msg)
        {
            message = msg;
        }
        public override string ToString()
        {
            return message;
        }
    }
}
