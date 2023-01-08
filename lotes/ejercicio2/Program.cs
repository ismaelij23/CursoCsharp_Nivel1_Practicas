using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vCod = new int[5], vPuntoA = new int[5];
            bool[] vPuntoB = new bool[12];
            float[] vPrecio = new float[5];
            

            cargar(vCod, vPrecio);
            ponerEnCero(5, ref vPuntoA);
            ponerEnFalse(12, ref vPuntoB);
            proceso(ref vCod, ref vPrecio, ref vPuntoA, ref vPuntoB);
            Console.WriteLine();
            funcionPuntoA(ref vCod, ref vPuntoA);
            Console.WriteLine();
            funcionPuntoB(vPuntoB);
            Console.WriteLine();
            funcionPuntoC(ref vCod, ref vPuntoA);

            /* for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("El articulo: " + vCod[x] + " tiene un precio de: " + vPrecio[x]);
            } */
            /* for (int x = 0; x < 12; x++)
            {
                Console.WriteLine(vPuntoB[x]); 
            } */
        }

        static void cargar(int[] vCod, float[] vPrecio){
            int codArt;
            float precio;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese el código de articulo: ");
                codArt = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio: ");
                precio = float.Parse(Console.ReadLine());

                vCod[x] = codArt;
                vPrecio[x] = precio;
            }
        }

        static void ponerEnCero(int espacios, ref int[] vPuntoA){
            for (int x = 0; x < espacios; x++)
            {
                vPuntoA[x] = 0;
            }
        }

        static void ponerEnFalse(int espacios, ref bool[] vPuntoB){
            for (int x = 0; x < espacios; x++)
            {
                vPuntoB[x] = false;
            }
        }

        static void proceso(ref int[] vCod, ref float[] vPrecio, ref int[] vPuntoA, ref bool[] vPuntoB){
            int nc = 1, ca = 1, m = 1, cv = 1, ind;
            Console.WriteLine("Ingrese el Número de cliente: ");
            nc = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de articulo: ");
            ca = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cv = int.Parse(Console.ReadLine());
            while (nc != 0)
            {
                ind = buscar(ca, ref vCod);
                vPuntoA[ind] += cv; 
                vPuntoB[m - 1] = true;

                Console.WriteLine("Ingrese otro Número de cliente: ");
                nc = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro codigo de articulo: ");
                ca = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro mes: ");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otra cantidad vendida: ");
                cv = int.Parse(Console.ReadLine());
            }
        }

        static int buscar(int ca, ref int[] vCod){
            for (int x = 0; x < 5; x++)
            {
                if(ca == vCod[x]){
                    return x;
                }
            }
           return 0;
        }

        static void funcionPuntoA(ref int[] vCod, ref int[] vPuntoA){
            /* int[] vAux = new int[5]; */
            /* copiarVector(ref vCod, ref vAux); */
            ordenarMayorMenor(ref vCod, ref vPuntoA);
            mostrar(vCod, vPuntoA);
        }

        static void copiarVector(ref int[] vCod, ref int[] vAux){
            for (int x = 0; x < 5; x++)
            {
                vAux[x] = vCod[x];
            }
        }

        static void ordenarMayorMenor(ref int[] vCod, ref int[] vPuntoA){
            int aux;
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if(vPuntoA[y] > vPuntoA[y + 1]){
                        aux = vPuntoA[y];
                        vPuntoA[y] = vPuntoA[y + 1];
                        vPuntoA[y + 1] = aux;

                        aux = vCod[y];
                        vCod[y] = vCod[y + 1];
                        vCod[y + 1] = aux;
                    }
                }
            }
        }
        static void mostrar(int[] vCod, int[] vPuntoA){
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Del articulo " + vCod[x] + " se vendieron " + vPuntoA[x] + " de cantidades...");
            }
        }

        static void funcionPuntoB(bool[] vPuntoB){
            for (int x = 0; x < 12; x++)
            {
                if(!vPuntoB[x]){
                    mMes(x);
                }
            }
        }

        static void mMes(int ind){
                    switch(ind){
                        case 0:
                        Console.WriteLine("En Enero no hubo ninguna venta :(");
                        break;
                        case 1:
                        Console.WriteLine("En Febrero no hubo ninguna venta :(");
                        break;
                        case 2:
                        Console.WriteLine("En Marzo no hubo ninguna venta :(");
                        break;
                        case 3:
                        Console.WriteLine("En Abril no hubo ninguna venta :(");
                        break;
                        case 4:
                        Console.WriteLine("En Mayo no hubo ninguna venta :(");
                        break;
                        case 5:
                        Console.WriteLine("En Junio no hubo ninguna venta :(");
                        break;
                        case 6:
                        Console.WriteLine("En Julio no hubo ninguna venta :(");
                        break;
                        case 7:
                        Console.WriteLine("En Agosto no hubo ninguna venta :(");
                        break;
                        case 8:
                        Console.WriteLine("En Septiembre no hubo ninguna venta :(");
                        break;
                        case 9:
                        Console.WriteLine("En Octubre no hubo ninguna venta :(");
                        break;
                        case 10:
                        Console.WriteLine("En Noviembre no hubo ninguna venta :(");
                        break;
                        case 11:
                        Console.WriteLine("En Diciembre no hubo ninguna venta :(");
                        break;    
                }
        }

        static void funcionPuntoC(ref int[] vCod, ref int[] vPuntoA){
            int acu = 0, promedio;

            for (int x = 0; x < 5; x++)
            {
                acu += vPuntoA[x];
            }

            promedio = acu / 5;

            for (int x = 0; x < 5; x++)
            {
                if(vPuntoA[x] > promedio){
                    Console.WriteLine("Las ventas del articulo " + vCod[x] + " son mayores al promedio, el cual es " + promedio);
                }
            }
        }
    }
}
