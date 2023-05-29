using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership
{
    public class Car
    {
        public string brand { get; }
        public string model { get; }
        public int price { get; }
        public int year { get; }
        public double engine { get; }
        public string gearbox { get; }
        public string condition { get; }
        public Car(string brand, string model, int price, int year,double engine,string gearbox, string condition) 
        {
            this.brand = brand; this.model = model; this.price = price;
            this.year = year; this.engine=engine; this.gearbox = gearbox;
            this.condition = condition;
        }
        public override string ToString()
        {
            return $"{brand} {model}. {year} year. {price} $.";
        }
    }
}
