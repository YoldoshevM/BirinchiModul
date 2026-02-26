using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.Arm;

namespace _3._7_Dars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1


            //var f1 = (User user) =>
            //{

            //    if (user.Age >= 18 )
            //    {
            //        return "Adult";
            //    }


            //    return "Minor";


            //};



            // 2


            //var act1 = (Car car) =>
            //{

            //    Console.WriteLine(DateTime.Now.Year - car.Year);

            //};


            // 3


            //var f2 = (List<Product> products) =>
            //{

            //    return products.OrderBy(p => p.Price).First();


            //};


            // 4


            //var act2 = (Order order) =>
            //{


            //    Console.WriteLine(order.Price * order.Quantity);


            //};


            // 5


            //var f3 = (List<Student> students) =>
            //{


            //    return students.Where(s => s.Grade > 90).ToList;


            //};



            // 6


            //var f4 = (Employee employee) =>
            //{

            //    var newS =  employee.Salary * 1.15m;

            //    return newS;


            //};



            // 7


            //var Unli = (string s ) =>
            //{


            //    return s.Count( s => "aeiou".Contains( s ) );


            //};



            // 8


            //var act3 = (int a , int b) =>
            //{

            //    Console.WriteLine(Math.Max(a,b));

            //};



            // 9


            //var f5 = (int n) =>
            //{

            //    if ( n % 2 != 0 )
            //    {
            //        return true;
            //    }

            //    return false;


            //};



            // 10


            //var f6 = (string s) =>
            //{


            //    return new string (s.Reverse().ToArray());


            //};



        }
    }
}

//public class User
//{

//    public string Name { get; set; }
//    public int Age { get; set; }

//}
//public class Car
//{

//    public string Model { get; set; }
//    public int Year { get; set; }

//}
//public class Product
//{

//    public string Name { get; set; }
//    public decimal Price { get; set; }

//}
//public class Order
//{

//    public int Quantity { get; set; }
//    public decimal Price { get; set; }

//}
//public class Student
//{

//    public string Name { get; set; }
//    public decimal Grade { get; set; }

//}
//public class Employee
//{

//    public string Name { get; set; }
//    public decimal Salary { get; set; }

//}
