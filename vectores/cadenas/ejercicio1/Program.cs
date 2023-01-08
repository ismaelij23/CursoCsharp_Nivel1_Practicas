using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cadena = new char[20];
            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese una letra: ");
            letra = char.Parse(Console.ReadLine());

            while(letra != '.' && indice < 19){
                cadena[indice] = letra;
                Console.WriteLine("Ingrese otra letra: ");
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            
            int cont = 0, l = 0;

            while(cadena[l] != '\0'){
                if(cadena[l] == 'a' || cadena[l] == 'A'){
                    cont++;
                }
                l++;
            }

            indice = 0;
            Console.Write("La palabra ");
            while(cadena[indice] != '\0' && indice < 20){
                Console.Write(cadena[indice]);
                indice++;
            }

            /* Console.WriteLine(); */
            Console.WriteLine(" tiene " + cont + " letras a");

            
           


        }
    }
}
