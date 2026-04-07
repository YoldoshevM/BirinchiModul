using _4_4_Project.Server.Entities;

namespace _4_4_Project.Server.Services
{
 public interface ICarService
        {
            void Add(Car car);
            void Delete(Guid id);
            List<Car> GetAll();
            Car GetById(Guid id);
        }

}
