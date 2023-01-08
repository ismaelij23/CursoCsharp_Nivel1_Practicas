using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contPares = 0, contImpares = 0, max = 0, min = 0;

            for (int i = 0; i < 10; i++)
            {   
                if(i == 0){
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                }
                else{
                Console.WriteLine("Ingrese otro: ");
                n = int.Parse(Console.ReadLine());
                }

                if(n % 2 == 0){
                    contPares++;
                    if(contPares == 1){
                        max = n;
                    }
                    else if(n > max) {
                        max = n;
                    }
                } else {
                    contImpares++;
                    if(contImpares == 1){
                        min = n;
                    }
                    else if(n < min){
                        min = n;
                    }
                }
            }

            Console.WriteLine("El máximo par es " + max + " y el mínimo impar es " + min + " :D...");
        }
    }
}
