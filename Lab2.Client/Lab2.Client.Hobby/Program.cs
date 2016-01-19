using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Client.Hobby
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in namnet på skon: ");
            var shoesName = Console.ReadLine();

            Console.WriteLine("Skriv in vilken storlek: ");
            var size = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in om det ska vara dam eller härrmodell (Kvinna/Man): ");
            var gender = Console.ReadLine();

            HobbyClient hobby = new HobbyClient();
            Console.WriteLine(hobby.Shoes(gender, shoesName, size));
            Console.ReadLine();
        }
    }
}
