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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            var deletedColor = _colorDal.Get(co => co.ColorId == color.ColorId);
            _colorDal.Delete(deletedColor);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetByIdColor(int id)
        {
            return _colorDal.Get(co=>co.ColorId==id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
