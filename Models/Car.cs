using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership
{
    internal class Car
    {
        private string brand;
        private string model;
        private int price;
        private int year;
        private double engine;
        private string gearbox;
        private string condition;
        public Car(string brand, string model, int price, int year,double engine,string gearbox, string condition) 
        {
            this.brand = brand; this.model = model; this.price = price;
            this.year = year; this.engine=engine; this.gearbox = gearbox;
            this.condition = condition;
        }
    }
}
