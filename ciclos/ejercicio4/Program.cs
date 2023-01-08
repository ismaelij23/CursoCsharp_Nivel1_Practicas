using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n ; i++)
            {
                if(n % i == 0){
                    cont++;
                }
            }

            if(cont == 2){
                Console.WriteLine("El numero " + n + " es primo");
            } else {
                Console.WriteLine("El numero " + n + " no es primo");
            }
        }
    }
}
