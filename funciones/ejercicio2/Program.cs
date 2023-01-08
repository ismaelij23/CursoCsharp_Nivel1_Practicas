using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, cont = 0;

            for (int x = 0; x < 6; x++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if(par(numero)){
                    cont++;
                }
            }

            Console.WriteLine("La cantidad total de pares es de " + cont);
        }

        static bool par(int num){
            if(num % 2 == 0)
                return true;
            else 
                return false;
            
        }
    }
}
