using car_dealership.Controls;
using car_dealership.Forms;
using car_dealership.Models;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace car_dealership
{
    public partial class Form1 : Form
    {
        private CarsList cars = new();
        private Users users = new();

        public Form1()
        {
            InitializeComponent();
            DataAccess.Load(cars,users);
            /*users.addUser("hello");
            users.addUser("me");
            users.addUser("admin");
            cars.AddCar(new Car("Daewoo", "Lanos", 100000, 2000, 1.3, "Mechanical", "New"));
            cars.AddCar(new Car("Daewoo", "Matiz", 100000, 2001, 1.3, "Mechanical", "New"));
            cars.AddCar(new Car("Daewoo", "Sens", 100000, 2002, 1.3, "Mechanical", "New"));*/
            //DataAccess.Save(cars, users);

            bindingSource1.DataSource = cars.getCars();
        }


        private void DoFilter()
        {

           List<Car> filtered = cars.filterBy(TextBoxFilterModel.Text, TextBoxFilterBrand.Text,
                TextBoxFilterYearFrom.Text, TextBoxFilterYearTo.Text,
                TextBoxFilterPriceFrom.Text, TextBoxFilterPriceTo.Text);
            bindingSource1.DataSource = filtered;
        }
        private void SaleCarStripButton_Click(object sender, EventArgs e)
        {
        }

        private void CarsList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GetCarInfoButton_Click(object sender, EventArgs e)
        {
            Car? car = CarsList.SelectedItem as Car;
            if (car == null) return;

            var form = new CarInfo(car);
            form.Show();
            form.BringToFront();
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
    }
}