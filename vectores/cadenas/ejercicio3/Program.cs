using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cadena = new char[20];
            int validacion = 1,ind = 0;
            char letra;

            Console.WriteLine("Ingrese una palabra letra por letra...(corta con punto)");
            letra = char.Parse(Console.ReadLine());

            while(letra != '.' && ind < 19){
                cadena[ind] = letra; 
                Console.WriteLine("Ingrese una palabra letra por letra...(corta con punto)");
                letra = char.Parse(Console.ReadLine());
                ind++;
            }

            cadena[ind] = '\0';
            ind = 0;
            while(cadena[ind] != '\0'){
                if(cadena[ind] == ' '){
                    validacion = 0;
                }
                ind++;
            }

            if(validacion == 1){
                Console.WriteLine("La validacion es positiva");
            }else{
                Console.WriteLine("La validacion es negativa");
            }

        }
    }
}
