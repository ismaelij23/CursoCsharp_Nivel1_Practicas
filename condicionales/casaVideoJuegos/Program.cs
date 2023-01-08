using System;

namespace casaVideoJuegos
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe;
            
            Console.WriteLine("Importe de venta: ");
            importe = float.Parse(Console.ReadLine());
            
            if(importe >= 5000)
                importe = importe * 0.82F;
            else{
                if(importe >= 1000)
                    importe = importe * 0.90F;
            }
            
            Console.WriteLine("El importe total es de " + "$" + importe);
        }
    }
}
