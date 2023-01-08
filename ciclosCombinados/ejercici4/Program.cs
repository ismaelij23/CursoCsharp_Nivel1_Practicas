using System;

namespace ejercici4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroPaquete, cantPersonas, precioXper, horas, contPtoA, acuPtoB = 0, bandPtoE = 0, ventaMax, precioExc, paqueteMenor = 0;
            char tipoAvent, tipoAventAct, tipoAventPtoE = 'e';

            Console.WriteLine("Ingrese el número de paquete: ");
            numeroPaquete = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de personas: ");
            cantPersonas = int.Parse(Console.ReadLine());

            Console.WriteLine("Cúal es el precio por persona?");
            precioXper = int.Parse(Console.ReadLine());

            Console.WriteLine("Cúantas horas?");
            horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de aventura: ");
            tipoAvent = char.Parse(Console.ReadLine());

            while(numeroPaquete != 0){
                tipoAventAct = tipoAvent;
                contPtoA = 0;
                ventaMax = 0;

                while(tipoAvent == tipoAventAct){
                    contPtoA++;
                    acuPtoB += cantPersonas;
                    precioExc = cantPersonas * precioXper;

                    if(precioExc > ventaMax){
                        ventaMax = precioExc;
                    }

                    if(bandPtoE == 0){
                        paqueteMenor = horas;
                        bandPtoE = 1;
                        tipoAventPtoE = tipoAvent;
                    } else {
                        if(horas < paqueteMenor){
                            paqueteMenor = horas;
                            tipoAventPtoE = tipoAvent;
                        }
                    }

                    Console.WriteLine("Ingrese el número de paquete: ");
                    numeroPaquete = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la cantidad de personas: ");
                    cantPersonas = int.Parse(Console.ReadLine());

                    Console.WriteLine("Cúal es el precio por persona?");
                    precioXper = int.Parse(Console.ReadLine());

                    Console.WriteLine("Cúantas horas?");
                    horas = int.Parse(Console.ReadLine());

                    Console.WriteLine("Tipo de aventura: ");
                    tipoAvent = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Cantitad total de personas en la temporada: " + acuPtoB + " y el paquete con menos horas incurridas fue " + tipoAventPtoE + " con un total de " + paqueteMenor);
        }
    }
}
