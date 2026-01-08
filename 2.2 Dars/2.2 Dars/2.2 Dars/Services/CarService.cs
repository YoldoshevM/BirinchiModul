//using _2._2_Dars.Models;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace _2._2_Dars.Services;

//public class CarService
//{
    
//    public List<Car> Cars = new List<Car>();


//    public Guid AddCar( Car car )
//    {
//        car.CarId = Guid.NewGuid();
//        Cars.Add(car);
//        return car.CarId;
        
//    }


//    public List<Car> GetCars()
//    {
//        return Cars;
//    } 

//    public bool DeleteCar(Guid carId)
//    {

//        foreach ( var car in Cars )
//        {

//            if ( car.CarId == carId )
//            {
//                Cars.Remove(car);
//                return true;
//            }

//            return false;

//        }

//    }
        

    