using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Client.Next1000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt födelsedatum: ");
            Next1000DaysClient next = new Next1000DaysClient();
            var birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(next.CalculateNext1000Days(birthday));
            Console.ReadLine();
        }
    }
}
