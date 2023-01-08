using System;

namespace ejercicio1C
{
    class Program
    {
        static void Main(string[] args)
        {
            int  c = 0, band, mayor, n;

            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                band = 0;
                mayor = n;

                while(n != 0){
                    if(n <= mayor){
                        mayor = n;
                    } else{
                        band = 1;
                    }
                    
                    Console.WriteLine("Ingrese otro número: ");
                    n = int.Parse(Console.ReadLine());
                }

                if(band == 0){
                    c++;
                }
            }

            Console.WriteLine("La cantidad total de grupos que tienen sus números ordenados de mayor a menor es de " + c);
        }
    }
}
