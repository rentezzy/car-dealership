using car_dealership.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_dealership.Forms
{
    public partial class Notifications : Form
    {
        public Notifications(User currentUser)
        {
            InitializeComponent();
            bindingSource_notifications.DataSource = currentUser.notifications;
            this.Text = currentUser.username;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Notifications_Load(object sender, EventArgs e)
        {
        }
    }
}
