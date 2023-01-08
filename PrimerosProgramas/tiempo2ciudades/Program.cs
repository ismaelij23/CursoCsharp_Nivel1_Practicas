using System;

namespace tiempo2ciudades
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilometros, velocidad, horas, minutos;

            Console.WriteLine("Ingrese d: ");
            kilometros = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese v: ");
            velocidad = float.Parse(Console.ReadLine());
            horas = kilometros / velocidad;
            minutos = (60 * horas) % 60;
            Console.WriteLine("El tiempo es de " + horas.ToString("0") + " horas" + " y " + minutos.ToString("00") + " minutos");
        }
    }
}
