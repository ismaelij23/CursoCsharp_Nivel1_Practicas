using System;

namespace ejercici1A
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPor = 0, n, contT, contIP, porcentajeIP, gmax = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingresa un número: ");
                n = int.Parse(Console.ReadLine());

                contT = 0;
                contIP = 0;

                while(n != 0){
                    contT++;
                    if(n % 2 != 0 && n > 0){
                        contIP++;
                    }
                    Console.WriteLine("Ingresa otro número: ");
                    n = int.Parse(Console.ReadLine());
                }

                porcentajeIP = contIP * 100 / contT;

                if(porcentajeIP > maxPor){
                    maxPor = porcentajeIP;
                    gmax = i + 1;
                }
            }

            Console.WriteLine("El número de grupo con mayor porcentaje de números impares positivos es el grupo " + gmax);
        }
    }
}
