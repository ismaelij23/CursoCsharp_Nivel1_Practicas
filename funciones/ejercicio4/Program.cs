using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, pos = 0, neg = 0, cer = 0, tipo = 0;

            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            while(num != 1){
                posNegCero(num, ref tipo);

                if(tipo == 0){
                    cer++;
                } else {
                    if( tipo == 1){
                        pos++;
                    } else {
                        neg++;
                    }
                }

                Console.WriteLine("Ingrese otro numero: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cantidad de CEROS: " + cer);
            Console.WriteLine("Cantidad de POSITIVOS: " + pos);
            Console.WriteLine("Cantidad de NEGATIVOS: " + neg);

        }

        static void posNegCero(int num, ref int var){
            if(num > 0)
                var = 1;
            else if(num < 0)
                var = -1;
            else 
                var = 0;
                
        }
    }
}

