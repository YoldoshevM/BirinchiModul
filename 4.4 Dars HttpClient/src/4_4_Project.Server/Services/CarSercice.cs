using _4_4_Project.Server.Entities;

namespace _4_4_Project.Server.Services;

public class CarSercice : ICarService
{

    private List<Car> cars = new List<Car>();

    public void Add(Car car)
    {
        car.CarId = Guid.NewGuid();
        cars.Add(car);
    }

    public void Delete(Guid id)
    {
        var car = cars.FirstOrDefault(x => x.CarId == id);
        if (car != null)
            cars.Remove(car);
    }

    public List<Car> GetAll()
    {
        return cars;
    }

    public Car GetById(Guid id)
    {
        return cars.FirstOrDefault(x => x.CarId == id);
    }


}