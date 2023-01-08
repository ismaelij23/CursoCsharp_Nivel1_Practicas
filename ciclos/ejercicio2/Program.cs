using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, mayor;

            Console.WriteLine("Ingresa un numerito: ");
            n = int.Parse(Console.ReadLine());
            mayor = n;
            
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Ingresa otro: ");
                n = int.Parse(Console.ReadLine());
                if(n > mayor){
                    mayor = n;
                }
            }

            Console.WriteLine("El numerito mayorcito es " + mayor);
        }
    }
}
