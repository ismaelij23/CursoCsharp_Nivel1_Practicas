using System;

namespace promedio
{
    class Program
    {
        static void Main(string[] args)
        {   
            float n1, n2, n3, promedio;

            Console.WriteLine("Nota 1: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota 3: ");
            n3 = float.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            Console.WriteLine("El promedio es de: " + promedio.ToString("0.00"));
        }
    }
}
