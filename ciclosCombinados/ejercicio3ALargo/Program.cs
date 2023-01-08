using System;

namespace ejercicio3ALargo
{
    class Program
    {
        static void Main(string[] args)
        {   
            int peso, camion = 0, pesoTotal;
            
            Console.WriteLine("Ingrese el peso de la encomienda: ");
            peso = int.Parse(Console.ReadLine());  

            while(peso > 0){
                pesoTotal = 0;
                camion++;
                while(peso + pesoTotal <= 200  && peso > 0){
                    pesoTotal += peso;
                    Console.WriteLine("Ingrese el peso de otra encomienda");
                    peso = int.Parse(Console.ReadLine());

                    if(peso + pesoTotal > 200){
                        Console.WriteLine("Se a excedido el limite de carga por encomienda, la misma sera cargada en el siguiente camión");
                    }
                }
                Console.WriteLine("Camión " + camion + ": " + pesoTotal + "kg.");
            }

        }
    }
}
