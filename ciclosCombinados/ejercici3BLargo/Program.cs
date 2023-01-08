using System;

namespace ejercici3BLargo
{
    class Program
    {
        static void Main(string[] args)
        {
            int peso, camion, camionMax = 0, enc, encMax, pesoCompleto;
            Console.WriteLine("Ingresa el peso de la encomienda: ");
            peso = int.Parse(Console.ReadLine());
            camion = 0;
            encMax = 0;

            while(peso > 0){
                pesoCompleto = 0;
                enc = 0;
                camion++;

                while(peso + pesoCompleto <= 200 && peso > 0){
                    pesoCompleto += peso;
                    enc++;
                    
                    Console.WriteLine("Ingrese otra encomienda: ");
                    peso = int.Parse(Console.ReadLine());

                    if(peso + pesoCompleto > 200){
                        Console.WriteLine("Esta encomienda será cargada en el próximo camión");
                    }
                }

                if(enc > encMax){
                    encMax = enc;
                    camionMax = camion;
                }
            }
            Console.WriteLine("El camión que cargó mayor cantidad de encomiendas es el " + camionMax);
            Console.WriteLine("La cantidad total de camiones es de " + camion);
        }
    }
}
