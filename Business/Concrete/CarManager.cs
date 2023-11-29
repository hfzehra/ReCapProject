using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //Dependecy injection 
        ICarDal _carService;
        public CarManager(ICarDal carService)
        {
            _carService = carService;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.CarName.Length > 2)
            {
                _carService.Add(car);
            }
        }

        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }

        public Car GetByIdCar(int id)
        {
            return _carService.Get(c=>c.id==id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carService.GetAll(c=>c.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carService.GetAll(c=>c.ColorId==id);
        }
    }
}
