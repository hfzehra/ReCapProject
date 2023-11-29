using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ReCapProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager cars = new CarManager(new EfCarDal());
            foreach (var c in cars.GetAll())
            {
                Console.WriteLine(c.Description );
            }
        }
    }
}