﻿
using On_DemandCarWash.Model;

namespace On_DemandCarWash.Interface
{
    public interface ICar
    {
        List<Car> GetAllCar();
        Car GetCar(int id);
        public string AddCar(Car car);
        public string UpdateCar(Car car);
        public string DeleteCar(int id);
    }
}

