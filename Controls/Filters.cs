﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_dealership.Controls
{
    public class Filters
    {
        private List<Car> carsOrigin { get; }
        private List<Car> carsDirty; 
        public Filters(List<Car> cars) { 
            this.carsOrigin = cars;
        }
        public List<Car> filterByModel(string model, string brand, string yearFrom , string yearTo, string priceFrom, string priceTo)
        {
            List<Car> result = new List<Car>();

            string m = model.ToLower();
            string b = brand.ToLower();
            int yF = 1900;
            int yT = 3000;
            int pF = 0;
            int pT = 10000000;

            if(yearFrom != "")
            {
                yF = int.Parse(yearFrom);
            };
            if (yearTo != "")
            {
                yT = int.Parse(yearTo);
            }
            if (priceFrom != "")
            {
                pF = int.Parse(priceFrom);
            };
            if (priceTo != "")
            {
                pT = int.Parse(priceTo);
            }


            foreach (Car car in carsOrigin)
            {
                if (car.model.ToLower().Contains(m) 
                    && car.brand.ToLower().Contains(b)
                    && car.year > yF
                    && car.year < yT
                    && car.price > pF
                    && car.price < pT)
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
