using System;

namespace entreMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, max, min;

            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            b = int.Parse(Console.ReadLine());

            if(a > b){
                max = a;
                min = b;
            } else {
                max = b;
                min = a;
            }

            min = min + 1;
            while(min < max){
                Console.WriteLine(min++);
            }
        }
    }
}
