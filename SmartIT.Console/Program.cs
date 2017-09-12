using SmartIT.DebugHelper;
using System;
namespace SmartIT.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            args.DDump("args");

            Employee employee = new Employee() { Id = 1, Name = "Jen" };
            employee.DDump("Employee");
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
} 
