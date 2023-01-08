using System;

namespace ejercicio3fixed
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesador, memoria, disco;
            float precio;
            
            Console.WriteLine("Ingrese la opcion de procesador: ");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la opcion de memoria RAM: ");
            memoria = int.Parse(Console.ReadLine());
            Console.WriteLine("Amplia disco?");
            disco = int.Parse(Console.ReadLine());

            switch(procesador){
                case 1:
                    switch(memoria)
                    {
                        case 1:
                            precio = 800;
                            break;
                        case 2:
                            precio = 900;
                            break;
                        default:
                            precio = 1000;
                            break;
                    }
                    break;
                case 2:
                    switch(memoria)
                    {
                       case 1:
                            precio = 900;
                            break;
                        case 2:
                            precio = 1000;
                            break;
                        default:
                            precio = 1400;
                            break; 
                    }
                    break;
                default:
                    switch(memoria)
                    {
                       case 1:
                            precio = 1200;
                            break;
                        case 2:
                            precio = 1400;
                            break;
                        default:
                            precio = 2000;
                            break; 
                    }
                    break;
            }

            if(disco == 1){
                precio = precio + 300;
            }

            Console.WriteLine("El monto total de su compra es de " + "$" + precio);
        }
    }
}
