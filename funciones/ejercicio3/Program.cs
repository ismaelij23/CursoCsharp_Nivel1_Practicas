using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, acu = 0, num, resultadoFun, promedio;

            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            while(num != 0){
                resultadoFun = primo(num);

                if(resultadoFun == 1){
                    acu += num;
                    cont++; 
                }

                Console.WriteLine("Ingrese otro número: ");
                num = int.Parse(Console.ReadLine());
            }

            promedio = acu / cont;

            Console.WriteLine("El promedio teniendo en cuenta solo los numeros primos es de " + promedio);
        }

        static int primo(int num){
            int cont = 0, j = 1;
            
            while(j <= num){
                if(num % j == 0){
                    cont++;
                }
                j++;
            }

            if(cont == 2){
                return 1;
            } else{
                return 0;
            }
        }
    }
}
