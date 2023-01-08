using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vcod = new int[8];
            float[] vprecio = new float[8];
            int codArt, precioUni;

            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine("Ingrese el código de articulo: ");
                codArt = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el precio unitario del articulo: ");
                precioUni = int.Parse(Console.ReadLine());
                vcod[x] = codArt;
                vprecio[x] = precioUni;
            }

            int[] vectorPuntoA = new int[4];
            bool[] vmes = new bool[12];

            for (int x = 0; x < 4; x++)
            {
                vectorPuntoA[x] = 0;
            }
            for (int x = 0; x < 12; x++)
            {
                vmes[x] = false;
            }

            int numCliente, cod, mes, dia, cant, ind = 1, aux;
            Console.WriteLine("Ingrese el numero de cliente: ");
            numCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de articulo: ");
            cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cant = int.Parse(Console.ReadLine());

            while(numCliente != 0){
                for (int x = 0; x < 4; x++)
                {
                    if(cod == vcod[x]){
                        ind = x;
                    }
                }
                vectorPuntoA[ind] += cant;
                vmes[mes - 1] = true;
                
                Console.WriteLine("Ingrese el numero de cliente: ");
                numCliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el codigo de articulo: ");
                cod = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el mes: ");
                mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el dia: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cant = int.Parse(Console.ReadLine());
            }

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if(vectorPuntoA[x] < vectorPuntoA[x + 1]){
                        aux = vectorPuntoA[x + 1];
                        vectorPuntoA[x + 1] = vectorPuntoA[x];
                        vectorPuntoA[x] = aux;
                        aux = vcod[x + 1];
                        vcod[x + 1] = vcod[x];
                        vcod[x] = aux;
                    }
                }
            }

            for (int x = 0; x < 4; x++)
            {   
                Console.WriteLine();
                Console.Write("El articulo numero " + vcod[x] + " se vendieron ");
                Console.WriteLine(vectorPuntoA[x] + " cantidades");
            }
            Console.WriteLine();
            for (int x = 0; x < 12; x++)
            {
                if(vmes[x] == false){
                    switch(x){
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
            }

            int acu = 0, promedio;

            for (int x = 0; x < 4; x++)
            {
                acu += vectorPuntoA[x];
            }

            promedio = acu/ 4;

            Console.WriteLine();

            for (int x = 0; x < 4; x++)
            {
                if(vectorPuntoA[x] > promedio){
                    Console.WriteLine("Las ventas del articulo " + vcod[x] + " son mayores al promedio, el cual es " + promedio);
                }
            }
        }
    }
}
