using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetByIdColor(int id);
        void Add(Color car);
        void Delete(Color car);
        void Update(Color car);
    }
}
