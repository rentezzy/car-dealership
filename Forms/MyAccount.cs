using car_dealership.Controls;
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
    public partial class MyAccount : Form
    {
        private Users users;
        private CarsList cars;
        public MyAccount(Users users, CarsList cars)
        {
            InitializeComponent();
            this.users = users;
            this.cars = cars;
            MyAccountCurrentUser.Text = users.currentUser.username;
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users.addUser(MyAccountUsername.Text);
            users.setUser(MyAccountUsername.Text);
            MyAccountCurrentUser.Text = users.currentUser.username;
            DataAccess.Save(cars, users);
        }
    }
}
