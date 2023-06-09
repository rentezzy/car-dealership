using car_dealership.Controls;
using car_dealership.Forms;
using car_dealership.Models;
using System.Windows.Forms;

namespace car_dealership
{
    public partial class Form1 : Form
    {
        private CarsList cars = new();
        private Users users = new();

        public Form1()
        {
            InitializeComponent();
            DataAccess.Load(cars, users);
            users.addUser("default");
            bindingSource1.DataSource = cars.getCars();
        }


        private void SaleCarStripButton_Click(object sender, EventArgs e)
        {
            var form = new SaleCar(cars, users);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                bindingSource1.DataSource = form.cars.getCars();
                bindingSource1.ResetBindings(true);
            }
        }

        private void NotificationsStripButton_Click(object sender, EventArgs e)
        {
            if (users.currentUser.username == "default")
            {
                MessageBox.Show("You must switch user to use it.", "ooppss...", MessageBoxButtons.OK);
                return;
            }
            var form = new Notifications(users.currentUser);
            form.Show();
        }

        private void ProfileStripButton_Click(object sender, EventArgs e)
        {
            var form = new MyAccount(users, cars);
            form.Show();
        }

        private void GetCarInfoButton_Click(object sender, EventArgs e)
        {
            Car? car = CarsList.SelectedItem as Car;
            if (car == null) return;

            var form = new CarInfo(car, users, cars);
            form.Show();
        }


        private void DoFilter()
        {
            List<Car> filtered = cars.filterBy(TextBoxFilterModel.Text, TextBoxFilterBrand.Text,
                 TextBoxFilterYearFrom.Text, TextBoxFilterYearTo.Text,
                 TextBoxFilterPriceFrom.Text, TextBoxFilterPriceTo.Text);
            bindingSource1.DataSource = filtered;
        }
        private void TextBoxFilterModel_TextChanged(object sender, EventArgs e)
        {
            DoFilter();
        }
        private void TextBoxFilterBrand_TextChanged(object sender, EventArgs e)
        {
            DoFilter();
        }

        private void TextBoxFilterYearFrom_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxFilterYearFrom.Text, "[^0-9]"))
            {
                TextBoxFilterYearFrom.Text = TextBoxFilterYearFrom.Text.Remove(TextBoxFilterYearFrom.Text.Length - 1);
            }

            DoFilter();
        }

        private void TextBoxFilterYearTo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxFilterYearTo.Text, "[^0-9]"))
            {
                TextBoxFilterYearTo.Text = TextBoxFilterYearTo.Text.Remove(TextBoxFilterYearTo.Text.Length - 1);
            }

            DoFilter();
        }

        private void TextBoxFilterPriceFrom_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxFilterPriceFrom.Text, "[^0-9]"))
            {
                TextBoxFilterPriceFrom.Text = TextBoxFilterPriceFrom.Text.Remove(TextBoxFilterPriceFrom.Text.Length - 1);
            }

            DoFilter();
        }

        private void TextBoxFilterPriceTo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxFilterPriceTo.Text, "[^0-9]"))
            {
                TextBoxFilterPriceTo.Text = TextBoxFilterPriceTo.Text.Remove(TextBoxFilterPriceTo.Text.Length - 1);
            }

            DoFilter();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataAccess.Save(cars, users);
        }
    }
}