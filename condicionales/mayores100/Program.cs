using System;

namespace mayores100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,n3, n4;
            
            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            n4 = int.Parse(Console.ReadLine());

            if(n1 > 100)
                Console.WriteLine(n1);
            if(n2 > 100)
                Console.WriteLine(n2);
            
            if(n3 > 100)
                Console.WriteLine(n3);
            
            if(n4 > 100)
                Console.WriteLine(n4);

        }
    }
}
