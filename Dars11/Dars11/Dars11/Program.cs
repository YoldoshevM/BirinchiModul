namespace Dars11;

internal class Program
{

    List<Employee> employees = new List<Employee>();


    static void Main(string[] args)
    {
        


    }


    static void AddEmployee(Employee employee)
    {
        employee.EmployeeId = Guid.NewGuid();
        employees.Add(employee);

    }

    static void RemoveEmployee(Guid employeeId )
    {

        foreach ( var employee in employees )
        {
            if ( employee.EmployeeId == employeeId )
            {
                employee.Remove( employee );
                break;
            }
        }

    }






    static Employee CreateEmployee()
    {

        return new Employee();

    }



    static void FillEmployee( Employee employee )
    {

        Console.Write( " Ismni kiriting : ");

        employee.FirstName = Console.ReadLine();

        Console.Write( " Familiyina kiriting : ");

        employee.LastName = Console.ReadLine();

        Console.Write( " positioni : ");

        employee.Position = Console.ReadLine();

        Console.Write( " Oylikni kiriting : ");

        employee.Salary = int.Parse( Console.ReadLine() );

        Console.Write( " Yoshni kiriting : ");

        employee.Age = int.Parse( Console.ReadLine() );

        Console.WriteLine();

    }












}
