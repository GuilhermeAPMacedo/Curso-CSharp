using Exercicio_Herança_Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Herança_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the numbers of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + " data: ");
                Console.Write("Outsourced(y/n): ");
                char conf = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (conf=='n' || conf=='N')
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                else
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2",CultureInfo.InvariantCulture)) ;
            }
        }
    }
}
