﻿using On_DemandCarWash.Interface;
using On_DemandCarWash.Model;

namespace On_DemandCarWash.Services
{
    public class CarService
    {
        private ICar _ICar;
        public CarService(ICar Icar)
        {
            _ICar = Icar;
        }
        public List<Car> GetAllCar()
        {
            return _ICar.GetAllCar();
        }
        public Car GetCar(int id)
        {
            return _ICar.GetCar(id);
        }
        public string AddCar(Car car)
        {
            return _ICar.AddCar(car);
        }
        public string UpdateCar(Car car)
        {
            return _ICar.UpdateCar(car);
        }
        public string DeleteCar(int id)
        {
            return _ICar.DeleteCar(id);
        }
    }
}
