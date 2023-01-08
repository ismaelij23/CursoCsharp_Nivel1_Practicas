using System;

namespace TPFinal_Juaristi
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, maximoPar = 0, contImpares = 0, minimoPrimo = 0;
            bool bandPrimo = false;

            Console.WriteLine("Ingrese un número: ");
            number = int.Parse(Console.ReadLine());

            while(number != 0){
                if(number % 2 == 0){
                    if(number > maximoPar){
                        maximoPar = number;
                    }
                } else {
                    contImpares++;
                }
                
                if(esPrimo(number)){
                    if(!bandPrimo){
                        minimoPrimo = number;
                        bandPrimo = true;
                    } else {
                        if(number < minimoPrimo){
                            minimoPrimo = number;
                        }
                    }
                }

                Console.WriteLine("Ingrese otro número: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El mayor de los pares es: " + maximoPar);
            Console.WriteLine("La cantidad total de impares es de: " + contImpares);
            Console.WriteLine("El menor de los números primos es: " + minimoPrimo);
        }

        static bool esPrimo(int num){
            int con = 0;

            for (int x = 1; x <= num; x++)
            {
                if(num % x == 0){
                    con++;
                }
            }

            if(con == 2)
                return true;
            else 
                return false;
        }
    }
}
