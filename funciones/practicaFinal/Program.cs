using System;

namespace practicaFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 10, h = -1, z;
            h += h;
            h++;
            g -= h;
            z = g;
            g = 5;
            h = 5;

            Console.WriteLine("H es:" + h);
            Console.WriteLine("G es: " + g);
            Console.WriteLine("Z es: " + z);
        }
    }
}
