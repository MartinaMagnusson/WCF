using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Client.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt födelsedatum: ");
            var birthday = DateTime.Parse(Console.ReadLine());

            DaysClient days = new DaysClient();
            Console.WriteLine(days.GetAge(birthday));
            Console.ReadLine();
        }
    }
}
