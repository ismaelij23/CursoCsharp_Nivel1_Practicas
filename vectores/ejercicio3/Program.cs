using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cadena = new char[25];
            char letra1, letra2, letter;
            int ind = 0;

            Console.WriteLine("Elija una letra cualquiera: ");
            letra1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ahora elegi otra: ");
            letra2 = char.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, ingrese una cadena de caracteres: ");
            letter = char.Parse(Console.ReadLine());
            while(letter != '.' && ind < 24){
                cadena[ind] = letter;
                letter = char.Parse(Console.ReadLine());
                ind++;
            }

            cadena[ind] = '\0';

            ind = 0;
            while(cadena[ind] != '\0' && ind < 24){
                if(cadena[ind] == letra1){
                    cadena[ind] = letra2;
                }
                ind++;
            }

            ind = 0;
            while(cadena[ind] != '\0' && ind < 24){
                Console.Write(cadena[ind]);
                ind++;
            }

        }
    }
}
