using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int  j, n, contPr = 0, contDiv;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                j = 1;
                contDiv = 0;

                while(j <= n){
                    if(n % j == 0){
                        contDiv++;
                    }
                    j++;
                }
                
                if(contDiv == 2){
                    contPr++;
                }
            }

            Console.WriteLine("La cantidad de números primos encontrados es de " + contPr);
        }
    }
}
