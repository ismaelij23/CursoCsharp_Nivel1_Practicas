using System;

namespace ejercicio3REAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vNroTarifa = new int[4], vImporte = new int[4], vTotalRecTarifa = new int[4], vRecaudado = new int[6], vCamion = new int[6], vKms = new int[6];
            int min;

            cargar(vNroTarifa, vImporte);
            ponerEnCero(vRecaudado);
            llenaVCamiones(vCamion);
            proceso(vNroTarifa, vImporte, vRecaudado, vTotalRecTarifa, vKms);
            Console.WriteLine();
            funcionPtoB(vCamion, vRecaudado);
            Console.WriteLine();
            min = minimo(vCamion,vKms);
            Console.WriteLine("El camion que menos recorrio fue el " + min + " con un total de " + vKms[min - 1] + "Kms");
        }

        static void cargar(int[] v1, int[] v2){
            int nroTarifa, importe;
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine("NroTarifa: ");
                nroTarifa = int.Parse(Console.ReadLine());
                Console.WriteLine("Importe: ");
                importe = int.Parse(Console.ReadLine());
                v1[x] = nroTarifa;
                v2[x] = importe;
            }
        }
        static void ponerEnCero(int[] vector){
            for (int x = 0; x < 6; x++)
            {
                vector[x] = 0;
            }
        }
        static void llenaVCamiones(int[] vCam){
            for (int x = 0; x < 6; x++)
            {
                vCam[x] = x + 1;
            }
        }
        static void proceso(int[] vNroTarifa, int[] vImporte, int[] vRecaudado, int[] vTotalRecTarifa, int[] vKms){
            int nroCamion, nroTarifa, kms, ind, t;
            Console.WriteLine("NroCamion: ");
            nroCamion = int.Parse(Console.ReadLine());
            Console.WriteLine("NroTarifa: ");
            nroTarifa = int.Parse(Console.ReadLine());
            Console.WriteLine("Kms recorridos: ");
            kms = int.Parse(Console.ReadLine());

            while(nroCamion != 0){
                ind = buscar(nroTarifa, vNroTarifa);
                t = total(vImporte[ind],kms);
                vRecaudado[nroCamion - 1] += t;
                vTotalRecTarifa[ind] += t;
                vKms[nroCamion - 1] += kms;

                Console.WriteLine("NroCamion... ");
                nroCamion = int.Parse(Console.ReadLine());
                Console.WriteLine("NroTarifa... ");
                nroTarifa = int.Parse(Console.ReadLine());
                Console.WriteLine("Kms recorridos... ");
                kms = int.Parse(Console.ReadLine());   
            }
        }
        static int buscar(int nroTarifa, int[] vTarifas){
            int ind = 0;
            for (int x = 0; x < 4; x++)
            {
                if(nroTarifa == vTarifas[x]){
                    ind = x;
                }
            }
            return ind;
        }
        static int total(int n1, int n2){
            int resultado;
            resultado = n1 * n2;
            return resultado;
        }

        static void funcionPtoB(int[] vCamion, int[] vRecaudado){
            /* int[] vAux = new int[6];
            copiaVector(vCamion, vAux); */
            ordenar(vCamion, vRecaudado);
            mostrar(vCamion, vRecaudado);

        }
        /* static void copiaVector(int[] v1, int[] v2){
            for (int x = 0; x < 6; x++)
            {
                v2[x] = v1[x];
            }
        } */
        static void ordenar(int[] vCam, int[] vRecaudado){
            int aux;
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if(vRecaudado[y] < vRecaudado[y + 1]){
                        aux = vRecaudado[y + 1];
                        vRecaudado[y + 1] = vRecaudado[y];
                        vRecaudado[y] = aux;

                        aux = vCam[y + 1];
                        vCam[y + 1] = vCam[y];
                        vCam[y] = aux;
                    }
                }
            }
        }
        static void mostrar(int[] v1, int[] v2){
            for (int x = 0; x < 6; x++)
            {
                Console.WriteLine("El camión nro " + v1[x] + " recaudo un total de $" + v2[x]);
            }
        }

        static int minimo(int[] vCam, int[] vKms){
            int band = 0, min = 0, camion = 1;
            for (int x = 0; x < 6; x++)
            {
                if(vKms[x] != 0){
                    if(band == 0){
                        min = vKms[x];
                        band = 1;
                        camion = vCam[x];
                    } else {
                        if(vKms[x] < min){
                            min = vKms[x];
                            camion = vCam[x];
                        }
                    }
                }
            }
            return camion;
        }
    }
}
