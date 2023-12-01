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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand car)
        {
            _brandDal.Add(car);
        }

        public void Delete(Brand car)
        {
            var deletedBrand = _brandDal.Get(b=>b.BrandId == car.BrandId);
            _brandDal.Delete(deletedBrand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetByIdBrand(int id)
        {
            return _brandDal.Get(b=>id == b.BrandId);
        }

        public void Update(Brand car)
        {
            _brandDal.Update(car);
        }
    }
}
