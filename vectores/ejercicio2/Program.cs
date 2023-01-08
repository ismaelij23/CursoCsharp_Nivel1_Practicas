using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int acu, promedio;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingresa un numero: ");
                numeros[x] = int.Parse(Console.ReadLine());
            }

            acu = 0;
            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }

            promedio = acu / 10;

            for (int x = 0; x < 10; x++)
            {
                if(numeros[x] > promedio){
                    Console.WriteLine("El número " + numeros[x] + " es mayor al promedio, el cual es " + promedio);
                }
            }
        }
    }
}
