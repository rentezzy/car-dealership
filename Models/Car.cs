using car_dealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership
{
    public class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int price { get; set; }
        public int year { get; set; }
        public double engine { get; set; }
        public string gearbox { get; set; }
        public string condition { get; set; }
        public User owner { get; set; }
        public Car()
        {
        }
        public Car(string brand, string model, int price, int year, double engine, string gearbox, string condition, User owner)
        {
            this.brand = brand; this.model = model; this.price = price;
            this.year = year; this.engine = engine; this.gearbox = gearbox;
            this.condition = condition; this.owner = owner;
        }
        public override string ToString()
        {
            return $"{brand} {model}. {year} year. {price} $.";
        }
    }
}
