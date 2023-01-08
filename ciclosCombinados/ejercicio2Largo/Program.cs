using System;

namespace ejercicio2Largo
{
    class Program
    {
        static void Main(string[] args)
        {
            int zona, numeroCliente,cantidadCons, zonaAct, cantUsuarios;
            float  total, totalFacturado;

            Console.WriteLine("Ingrese la zona: ");
            zona = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de cliente: ");
            numeroCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de energía consumida: ");
            cantidadCons = int.Parse(Console.ReadLine());

            while(zona != 0){
                zonaAct = zona;
                cantUsuarios = 0;
                totalFacturado = 0;

                while(zona == zonaAct){
                    cantUsuarios++;
                    if(cantidadCons  > 201){
                        total = cantidadCons * 0.15F;
                    } else {
                        if(cantidadCons >= 102){
                            total = 0.12F * cantidadCons;
                        } else{
                            total = 0.10F * cantidadCons;
                        }
                    }
                    totalFacturado += total;
                    Console.WriteLine("Ingrese la zona: ");
                    zona = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el número de cliente: ");
                    numeroCliente = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad de energía consumida: ");
                    cantidadCons = int.Parse(Console.ReadLine());
                }
                
                Console.WriteLine("En la zona " + zonaAct + " hubo un registro de " + cantUsuarios + " usuarios y se facturo un total de " + "$" + totalFacturado );
            }   
        }
    }
}
