using System;
using Curso4.Entities;
using Curso4.Entities.Enums;
using System.Globalization;

namespace Curso4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name: ");
            string nameD = Console.ReadLine();
            Console.WriteLine("Enter worker Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("how many contracts to this worker? ");
            int nCont = int.Parse(Console.ReadLine());
            Worker worker = new Worker(name, level, baseSalary,new Department( nameD));


            for(int i = 1; i <= nCont; i++)
            {
                Console.WriteLine($"enter contract{i} data: " );
                Console.WriteLine("Date(DD/MM/yyyy): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine() ,"dd/MM/yyyy",CultureInfo.InvariantCulture);
                Console.WriteLine("Value  PEr hour: ");
                double valueHour = double.Parse(Console.ReadLine());
                Console.WriteLine("duration(Hours): ");
                int duration = int.Parse(Console.ReadLine()) ;
                HourContract contract = new HourContract(date, valueHour, duration);
                worker.AddContract(contract);

            }

            Console.WriteLine("enter month and year to calculate income (MM/yyyy): ");
            string monthYear = Console.ReadLine();
            int year = int.Parse(monthYear.Substring(3));
            int month = int.Parse(monthYear.Substring(0,2));

            Console.WriteLine($"Name: {worker.Name}\n " +
                $"Department:{worker.Department.Name}\n" +
                $"WorkerLevel:{worker.Level}\n" +
                $"income for{monthYear}: {worker.Income(month, year)} " );

        }
    }
}