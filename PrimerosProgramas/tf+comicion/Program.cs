using System;

namespace tf_comicion
{
    class Program
    {
        static void Main(string[] args)
        {
            float totalFacturado, comision, sueldoFinal;

            Console.WriteLine("Total facturado: ");
            totalFacturado = float.Parse(Console.ReadLine());
            comision = totalFacturado * 0.05F;
            sueldoFinal = comision + 15000;
            Console.WriteLine("El sueldo total del empleado es de " + sueldoFinal);
            
        }
    }
}
