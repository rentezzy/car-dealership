using car_dealership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace car_dealership.Controls
{
    public static class DataAccess
    {
        const string DATA_PATH_CARS = "Cars.json";
        const string DATA_PATH_USERS = "Users.json";

        public static void Save(CarsList cars, Users users)
        {
            string jsonStringCars = JsonSerializer.Serialize(cars.getCars());
            string jsonStringUsers = JsonSerializer.Serialize(users.getUsers());
            File.WriteAllText(DATA_PATH_CARS, jsonStringCars);
            File.WriteAllText(DATA_PATH_USERS, jsonStringUsers);
        }

        public static void Load(CarsList cars, Users users)
        {
            string jsonStringCars = File.ReadAllText(DATA_PATH_CARS);
            string jsonStringUsers = File.ReadAllText(DATA_PATH_USERS);
            var carList = JsonSerializer.Deserialize<List<Car>>(jsonStringCars);
            var userList = JsonSerializer.Deserialize<List<User>>(jsonStringUsers);
            cars.setCars(carList);
            users.users = userList;
        }

    }
}
