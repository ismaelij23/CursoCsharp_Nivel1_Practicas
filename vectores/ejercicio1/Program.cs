using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, posicion;
            int[] numeros = new int[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                numeros[x] = int.Parse(Console.ReadLine());
            }

            max = numeros[0];
            posicion = 1;
            for (int x = 1; x < 10; x++)
            {
                if(numeros[x] > max){
                    max = numeros[x];
                    posicion = x + 1;
                }
            }

            Console.WriteLine("El mayor de todos los números es: " + max + ", y su posicion es " + posicion);
        }
    }
}
