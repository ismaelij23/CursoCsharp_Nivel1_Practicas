using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vArt = new int[4], vStock = new int[4], vPrecio = new int[4], vPuntoB = new int[4], vPuntoC = new int[4];
            int maximoComprador;

            cargar(vArt, vStock, vPrecio);
            ponerEnCero(vPuntoB);
            ponerEnCero(vPuntoC);
            proceso(vArt, vPuntoC, vPrecio, vPuntoB);
            Console.WriteLine();
            maximoComprador = maximoClienteCompras(vPuntoB);
            Console.WriteLine("El cliente que mas compró fue el número " + maximoComprador);
            Console.WriteLine();
            mostrar(vPuntoC, vArt);

        }

        static void cargar(int[] v1, int[] v2, int[] v3){
            int articulo, unidStock, precio;
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine("Articulo: ");
                articulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Unidades en stock: ");
                unidStock = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio unitario: ");
                precio = int.Parse(Console.ReadLine());

                v1[x] = articulo;
                v2[x] = unidStock;
                v3[x] = precio;
            }
        }

        static void ponerEnCero(int[] vector){
            for (int x = 0; x < 4; x++)
            {
                vector[x] = 0;
            }
        }

        static void proceso(int[] vArt, int[] vPuntoC, int[] vPrecio, int[] vPuntoB){
            int nroCliente, nroArt, cantVendida, ind, importeTotal;
            Console.WriteLine("Número de cliente: ");
            nroCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de articulo: ");
            nroArt = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad vendida: ");
            cantVendida = int.Parse(Console.ReadLine());

            while (nroCliente != 0)
            {
                ind = buscar(nroArt, vArt);
                importeTotal = vPrecio[ind] * cantVendida;
                vPuntoB[nroCliente - 1] += importeTotal;
                vPuntoC[ind] = 1;
                Console.WriteLine("NroCliente: " + nroCliente + " NroArt: " + nroArt + " CantVendida: " + cantVendida + " Importe total: " + importeTotal);

                Console.WriteLine("Número de cliente... ");
                nroCliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Número de articulo... ");
                nroArt = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad vendida... ");
                cantVendida = int.Parse(Console.ReadLine());

            }
        }

        static int buscar(int nroArt, int[] vArt){
            for (int x = 0; x < 4; x++)
            {
                if(nroArt == vArt[x]){
                    return x;
                }
            }
            return 404;
        }

        static int maximoClienteCompras(int[] vPuntoB){
            int maximo = vPuntoB[0], max = 1;
            for (int x = 1; x < 4; x++)
            {
                if(vPuntoB[x] > maximo){
                    maximo = vPuntoB[x];
                    max = x + 1;
                }
            }
            return max;
        }
        
        static void mostrar(int[] vPuntoC, int[] vArt){
            for (int x = 0; x < 4; x++)
            {
                if(vPuntoC[x] == 0){
                    Console.WriteLine("El articulo " + vArt[x] + " no registró ventas...");
                }
            }
        }
    }
}
