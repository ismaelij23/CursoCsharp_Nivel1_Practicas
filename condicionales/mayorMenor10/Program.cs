using System;

namespace mayorMenor10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            if (numero > 10)
                Console.WriteLine("Es mayor");
            else 
                Console.WriteLine("No es mayor");

        }
    }
}
