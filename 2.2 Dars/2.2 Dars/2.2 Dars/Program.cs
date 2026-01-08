using _2._2_Dars.Models;
using _2._2_Dars.Services;
using System.Drawing;

namespace _2._2_Dars;

internal class Program
{

    static void Main(string[] args)
    {


        Car car1 = new Car()
        {

            Color = "Black",
            Name = "Malibu",
            Brand = "Chevrolet",
            MaxSpeed = 250,
            Price = 25000,

        };

        Car car2 = new Car()
        {

            Color = "White",
            Name = "Nexia 2",
            Brand = "Chevrolet",
            MaxSpeed = 220,
            Price = 10000,

        };

        Car car3 = new Car()
        {

            Color = "Red",
            Name = "Spark",
            Brand = "Chevrolet",
            MaxSpeed = 180,
            Price = 8000,

        };



        CarService carService = new CarService();

        var car1Id = carService.AddCar(car1);
        var car2Id = carService.AddCar(car2);
        var car3Id = carService.AddCar(car3);


        carService.DeleteCar(car2Id);

        var cars = carService.GetCars();






    }





}






