using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership.Controls
{
    internal class Filters
    {
        List<Car> cars;
        public Filters(List<Car> cars) { 
            this.cars = cars;
        }
        public List<Car> filterByModel(string text)
        {
            List<Car> result = new List<Car>();

            string t = text.ToLower();

            foreach (Car car in cars)
            {
                if (car.model.ToLower().Contains(t))
                {
                    result.Add(car);
                }
            }

            cars = result;
            return cars;
        }
    }
}
