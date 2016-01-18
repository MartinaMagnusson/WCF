using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Client.BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din vikt: ");
            var weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in din längd i meter: ");
            var length = double.Parse(Console.ReadLine());

            BMIClient bmi = new BMIClient();
            Console.WriteLine(bmi.CalculateBMI(weight, length));
            Console.ReadLine();
        }
    }
}
