using System;

namespace ejercici1B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ultPr, rec, posicion = 0, j, c;

            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                ultPr = 0;
                rec = 1;
                while(n != 0){
                    
                    j = 1;
                    c = 0;

                    while(j <= n){
                        if(n % j == 0){
                            c++;
                        }
                        j++;
                    }

                    if(c == 2){
                        ultPr = n;
                        posicion = rec;
                    }

                    rec++;

                    Console.WriteLine("Ingrese otro número: ");
                    n = int.Parse(Console.ReadLine());
                }

                if(ultPr != 0){
                    Console.WriteLine("El ultimo número primo del grupo " + (x + 1) + " es " + ultPr + " y se encuentra en la posición " + posicion);
                } else {
                    Console.WriteLine("El grupo " + (x + 1) + " no cuenta con ningun número primo");
                }
                
            }
        }
    }
}
