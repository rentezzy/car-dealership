using car_dealership.Controls;
using car_dealership.Forms;
using System.Windows.Forms;

namespace car_dealership
{
    public partial class Form1 : Form
    {
        public CarsList cars = new();

        public Filters filter;
        public Form1()
        {
            InitializeComponent();

            cars.AddCar(new Car("Daewoo", "Lanos", 100000, 2000, 1.3, "Mechanical", "New"));
            cars.AddCar(new Car("Daewoo", "Matiz", 100000, 2001, 1.3, "Mechanical", "New"));
            cars.AddCar(new Car("Daewoo", "Sens", 100000, 2002, 1.3, "Mechanical", "New"));

            filter = new(cars.getCars());

            bindingSource1.DataSource = cars.getCars();
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter.filterByModel(textBox1.Text);
            bindingSource1.DataSource = filter.getCars();
        }
    }
}