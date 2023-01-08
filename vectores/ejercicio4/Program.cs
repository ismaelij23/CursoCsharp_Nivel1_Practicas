using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorCantidades = new int[15];
            int numArt, cant, max, artMax = 0;

            Console.WriteLine("Ingrese el numero de articulo y la cantidad que compra");
            numArt = int.Parse(Console.ReadLine());
            cant = int.Parse(Console.ReadLine());

            while(numArt != 0){
                vectorCantidades[numArt - 1] += cant; 
                Console.WriteLine("Ingrese el numero de articulo y la cantidad que compra");
                numArt = int.Parse(Console.ReadLine());
                cant = int.Parse(Console.ReadLine());
            }

            max = vectorCantidades[0];

            for (int x = 1; x < 15; x++)
            {
                if(vectorCantidades[x] > max){
                    max = vectorCantidades[x];
                    artMax = x + 1;
                }
                if(vectorCantidades[x] == 0){
                    Console.WriteLine("El articulo " + (x+1) + " no registro ventas");
                }
            }

            Console.WriteLine("El articulo que mas se vendio fue el " + artMax + " con un total de " + max);
            Console.WriteLine("El numero de articulo 10 se vendio un total de " + vectorCantidades[9]);
        }
    }
}
