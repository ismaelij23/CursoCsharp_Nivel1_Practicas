using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, cont, acu, promedio;

            acu = 0;
            cont = 0;
            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            
            if(edad > 18){
                cont = 1;
            }
            
            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine("Ingrese otra edad: ");
                edad = int.Parse(Console.ReadLine());
                if(edad > 18){
                    cont++;
                    acu += edad;
                }
            }

            promedio = acu / cont;
            
            Console.WriteLine("El promedio de edad de las personas mayores es de " + promedio);
        }
    }
}
