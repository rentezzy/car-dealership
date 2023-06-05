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
    public partial class SaleCar : Form
    {
        public CarsList cars;
        public Users users;
        public SaleCar(CarsList cars, Users users)
        {
            InitializeComponent();
            this.cars = cars;
            this.users = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (users.currentUser.username == "default")
            {
                MessageBox.Show("You must switch user to use it.", "ooppss...", MessageBoxButtons.OK);
                return;
            }
            string errors = "";
            double engine = 0;

            if (SaleCarBrand.Text == "") errors += "Car must have a brand. ";
            if (SaleCarModel.Text == "") errors += "Car must have a model. ";
            if (SaleCarPrice.Text == "") errors += "Car must have a price. ";
            if (SaleCarYear.Text == "") errors += "Car must have a year. ";
            try
            {
                engine = Convert.ToDouble(SaleCarEngine.Text);
            }
            catch
            {
                errors += "Engine must be a number in format *,* ";
            }
            if (errors != "")
            {
                MessageBox.Show(errors, "ooppss...", MessageBoxButtons.OK);
                return;
            }

            string condition = SaleCarCondition.Text;
            if (SaleCarCondition.Text == "")
            {
                condition = "Used";
            }

            string gearbox = SaleCarGearbox.Text;
            if (SaleCarGearbox.Text == "")
            {
                gearbox = "Not specified";
            }


            cars.addCar(new Car(SaleCarBrand.Text, SaleCarModel.Text, int.Parse(SaleCarPrice.Text), int.Parse(SaleCarYear.Text), engine, gearbox, condition, users.currentUser));

            DataAccess.Save(cars, users);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaleCarPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SaleCarPrice.Text, "[^0-9]"))
            {
                SaleCarPrice.Text = SaleCarPrice.Text.Remove(SaleCarPrice.Text.Length - 1);
            }
        }

        private void SaleCarYear_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SaleCarYear.Text, "[^0-9]"))
            {
                SaleCarYear.Text = SaleCarYear.Text.Remove(SaleCarYear.Text.Length - 1);
            }
        }

    }
}
