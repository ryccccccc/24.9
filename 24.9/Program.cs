
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector();
            v1.x = 2;
            v1.y = 2;
            Vector v2 = new Vector();
            v2.x = 3;
            v2.y = 3;
            Vector v3 = Vector.Parse("4;4");

            Console.WriteLine("V1({0},{1})", v1.x, v1.y);
            Console.WriteLine("V2({0},{1})", v2.x, v2.y);
            Console.WriteLine("V1 + V2 = V3({0},{1})", v1.Somma(v2).x, v1.Somma(v2).y);
            Console.ReadLine();
        }
    }
}
