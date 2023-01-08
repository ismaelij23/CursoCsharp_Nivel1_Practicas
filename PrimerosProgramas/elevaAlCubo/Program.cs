using System;

namespace elevaAlCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n, resultado;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
            resultado = n * n * n;
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
