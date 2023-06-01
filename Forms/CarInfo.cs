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
    public partial class CarInfo : Form
    {
        private Car car;
        private Users users;
        private CarsList cars;
        public CarInfo(Car car, Users users, CarsList cars)
        {
            InitializeComponent();

            this.car = car;
            this.users = users;
            this.cars = cars;

            this.Text = car.ToString();
            CarInfoModel.Text = car.model;
            CarInfoBrand.Text = car.brand;
            CarInfoPrice.Text = $"{car.price} $";
            CarInfoYear.Text = $"{car.year}";
            CarInfoCondition.Text = car.condition;
            CarInfoEngine.Text = $"{car.engine}";
            CarInfoGearbox.Text = car.gearbox;
            CarInfoOwner.Text = car.owner.username;
        }

        private void CarInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (car.owner.username == users.currentUser.username || users.currentUser.username == "default") return;
            foreach (User u in users.users)
            {
                if (u.username == car.owner.username)
                {
                    u.AddNotification($"User '{users.currentUser.username}', want to buy your car : {car.ToString()}");
                    DataAccess.Save(cars, users);
                }
            }
        }
    }
}
