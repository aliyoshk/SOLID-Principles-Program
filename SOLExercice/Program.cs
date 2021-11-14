using System;

namespace SOLExercice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee;
            string name, pass;

            Console.WriteLine("Enter your Username and Password");
            name = Console.ReadLine();
            pass = Console.ReadLine();

            employee = new FullTimeEmployee();
            employee = new PartTimeEmployee();
            employee.Login(name, pass);

            Console.WriteLine("Employee Name "  +employee.LoginName);
            Console.WriteLine("Employee Password " +employee.Password);
            Console.WriteLine("Employee ID " + employee.EmployeeID);
            Console.WriteLine("Employee Department " + employee.Department);


            Console.ReadKey();

        }
    }
}
