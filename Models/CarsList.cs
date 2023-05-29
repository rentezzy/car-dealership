using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership
{
    public class CarsList
    {
        private List<Car> cars;
        public CarsList()
        {
            this.cars = new List<Car>();
        }

        public CarsList(List<Car> cars)
        {
            this.cars = cars;
        }

        public List<Car> getCars() {  return cars; }
        public void AddCar(Car car) 
        { 
            cars.Add(car);
        }

    }
}
