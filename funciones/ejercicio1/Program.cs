using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio, cantidad, total;
            Console.WriteLine("Ingrese el precio del articulo: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());

            total = producto(precio, cantidad);

            Console.WriteLine("El precio total es de $" + total);
        }

        static int producto(int n1, int n2){
            int resultado;
            resultado = n1 * n2;
            return resultado;
        }
    }
}
