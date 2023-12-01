using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        ICarDal _carDal;
        public CarManager(ICarDal carService)
        {
            _carDal = carService;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 || car.CarName.Length > 2)
            {
                _carDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            var deletedCar = _carDal.Get(c=>c.id == car.id);
            _carDal.Delete(deletedCar);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetByIdCar(int id)
        {
            return _carDal.Get(c=>c.id==id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id).OrderBy(c => c.DailyPrice).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c=>c.ColorId==id);
        }

        public void Update(Car car)
        {
            Car car1 = _carDal.Get(c=> c.id == car.id);
            car1.DailyPrice = car.DailyPrice;
            car1.ColorId = car.ColorId;
            car1.BrandId = car.BrandId;
            _carDal.Update(car1);
        }
    }
}
