using System;

namespace posNegCero
{
    class Program
    {
        static void Main(string[] args)
        {   
            int numero;
            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            if (numero > 0)
                Console.WriteLine("El número es positivo");
            else {
                if (numero < 0)
                    Console.WriteLine("El número es negativo");
                else 
                    Console.WriteLine("El número es 0");
            }
        }
    }
}
