using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("enter x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y:");
            y = Convert.ToInt32(Console.ReadLine());
            double a;
            a = Math.Pow(x, 5);
            double b;
            b = Math.Pow(x, 4);
            double c;
            c = a + 2 * (b);
            double d;
            d = Math.Pow(y, 2) - 7;

            Console.WriteLine(c * d);
        }
    }
}
