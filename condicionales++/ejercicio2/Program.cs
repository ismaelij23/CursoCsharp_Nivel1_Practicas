using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float imp, cant;

            Console.WriteLine("Importe total: ");
            imp = float.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad vendida: ");
            cant = float.Parse(Console.ReadLine());

            if(cant > 500)
                imp = imp * 0.75F;
            else
                if(cant >= 301 && cant <= 500)
                    imp = imp * 0.85F;
                else
                    if(cant > 100)
                        imp = imp * 0.90F;
            
            Console.WriteLine("El importe final es de " + imp);
    
        }
    }
}
