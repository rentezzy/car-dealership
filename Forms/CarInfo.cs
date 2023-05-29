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
        public CarInfo(Car car)
        {
            InitializeComponent();

            this.Text = car.ToString();
            CarInfoModel.Text = car.ToString();
        }

        private void CarInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
