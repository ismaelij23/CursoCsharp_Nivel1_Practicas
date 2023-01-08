using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cadena1 = new char[25];
            char[] cadena2 = new char[25];
            int posicion = 0, ind = 0;
            char letra, letraNueva = 'a';

            Console.WriteLine("Ingrese una palabra letra por letra: ");
            letra = char.Parse(Console.ReadLine());

            while(letra != '.' && ind < 24){
                cadena1[ind] = letra;
                Console.WriteLine("Ingrese una palabra letra por letra: ");
                letra = char.Parse(Console.ReadLine());
                ind++;
            }
            cadena1[ind] = '\0';
            ind = 0;

            Console.WriteLine("Ahora ingrese una letra: ");
            letraNueva = char.Parse(Console.ReadLine());
            Console.WriteLine("Elija la posicion donde se va a incorporar: ");
            posicion = int.Parse(Console.ReadLine());

            while(cadena1[ind] != '\0'){
                cadena2[ind] = cadena1[ind];
                ind++;
            }

            cadena2[ind] = '\0';
            cadena2[posicion - 1] = letraNueva;

            while(cadena1[posicion - 1] != '\0' && posicion < 25){
                cadena2[posicion] = cadena1[posicion - 1];
                posicion++;
            }

            Console.Write("La palabra es ");
            ind = 0;
            while(cadena2[ind] != '\0'){
                Console.Write(cadena2[ind]);
                ind++;
            }
        }
    }
}
