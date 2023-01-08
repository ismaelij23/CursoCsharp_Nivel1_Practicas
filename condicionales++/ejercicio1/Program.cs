using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, r;

            Console.WriteLine("Ingresa un numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro: ");
            n2 = int.Parse(Console.ReadLine());

            if(n1 == n2)
                r = n1 + n2;
            else{
                
                if(n1 > n2)
                r = n1 - n2;
                
                else
                r = n1 * n2;
            }
            
            Console.WriteLine("El resultado es: " + r);
            
        }
    }
}
