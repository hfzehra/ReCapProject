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

        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }

        public Car GetByIdCar(int id)
        {
            return _carService.Get(c=>c.id==id);
        }
    }
}
