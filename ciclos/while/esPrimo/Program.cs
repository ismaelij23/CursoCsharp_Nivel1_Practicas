using System;

namespace esPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, j = 1, c = 0;

            Console.WriteLine("ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while(j <= n){
                if(n % j == 0) {
                    c++;
                }
                j++;
            }

            if(c == 2){
                Console.WriteLine("El numero " + n + " es primo");
            } else {
                Console.WriteLine("El numero " + n + " no es primo");
            }
        }
    }
}
