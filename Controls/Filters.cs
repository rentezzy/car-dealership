using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership.Controls
{
    public class Filters
    {
        public List<Car> carsOrigin { get; }
        private List<Car> carsDirty; 
        public Filters(List<Car> cars) { 
            this.carsOrigin = cars;
        }
        public List<Car> filterByModel(string text)
        {
            List<Car> result = new List<Car>();

            string t = text.ToLower();

            foreach (Car car in carsOrigin)
            {
                if (car.model.ToLower().Contains(t))
                {
                    result.Add(car);
                }
            }

            carsDirty = result;
            return carsDirty;
        }
        public List<Car> filterByBrand(string text)
        {
            List<Car> result = new List<Car>();

            string t = text.ToLower();

            foreach (Car car in carsOrigin)
            {
                if (car.brand.ToLower().Contains(t))
                {
                    result.Add(car);
                }
            }

            carsDirty = result;
            return carsDirty;
        }

        public List<Car> getCars()
        {
            return carsDirty;
        }
    }
}
