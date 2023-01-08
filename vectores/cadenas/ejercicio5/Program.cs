using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cadena = new char[50];
            char[] palabra = new char[20];
            char letra;
            bool validacion = false;
            int cc = 0, cp = 0, ind = 0;

            Console.WriteLine("LLene la cadena de caracteres: ");
            letra = char.Parse(Console.ReadLine());

            while(letra != '.' && ind < 49){
                cadena[ind] = letra;
                Console.WriteLine("LLene la cadena de caracteres: ");
                letra = char.Parse(Console.ReadLine());
                ind++;
            }

            cadena[ind] = '\0';
            ind = 0;
            
            Console.WriteLine("LLene la palabra con caracteres: ");
            letra = char.Parse(Console.ReadLine());

            while(letra != '.' && ind < 49){
                palabra[ind] = letra;
                Console.WriteLine("LLene la palabra con caracteres: ");
                letra = char.Parse(Console.ReadLine());
                ind++;
            }

            palabra[ind] = '\0';
           

            while(palabra[cp] != '\0'){
                cp++;
            }
            while(cadena[cc] != '\0'){
                cc++;
            }


             /* ind = 0;
            while(cadena[ind] != '\0'){
                Console.Write(cadena[ind]);
                ind++;
            }
            ind = 0;
            Console.WriteLine();
            while(palabra[ind] != '\0'){
                Console.Write(palabra[ind]);
                ind++;
            }
            Console.WriteLine();
            Console.WriteLine("la cadena tiene " + cc + "y la palabra " + cp); */

            int vueltas = cc, cind = 0, ax, cont;
            
            for (int x = 0; x < cc; x++)
            {
                ax = x;
                cont = 0;
                if(vueltas >= cp){
                    if(palabra[0] == cadena[ax]){
                        ax++;
                        cont++;
                        for (int y = 1; y < cp; y++)
                        {
                            if(palabra[y] == cadena[ax]){
                                cont++;
                                ax++;
                            }
                        }
                    }
                }
                if(cont == cp){
                    validacion = true;
                }
                cind++;
                vueltas = cc - cind;
            }

            if(validacion == true){
                Console.WriteLine("La palabra se encuentra dentro de la cadena de caracteres");
            }else{
                Console.WriteLine("La palabra no se encuentra dentro de la cadena de caracteres");
            }

        }
    }
}
