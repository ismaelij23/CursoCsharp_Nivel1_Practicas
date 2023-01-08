using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numProv = 001, numProvAct, mes = 1, numProd = 00, cant = 0, b = 0, contD, numProdMax = 1;
            float precioUnit = 0, montoMayor, montoAct, acuA = 0, acuB = 0, acuC = 0, menorCompra = 12, prodMin = 0, max = 0;
            char tipoFactura = 'a';

            Console.WriteLine("ingrese el numero de proveedor: ");
            numProv = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de factura: ");
            tipoFactura = char.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero de producto: ");
            numProd = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad comprada: ");
            cant = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el precio por unidad");
            precioUnit = float.Parse(Console.ReadLine());

            while(numProv != 0){
                numProvAct = numProv;

                montoMayor = 0;
                contD = 0;

                while(numProv == numProvAct){
                    montoAct = cant * precioUnit;
                    if(montoAct > montoMayor){
                        montoMayor = montoAct;
                    }
                    if(tipoFactura == 'a'){
                        acuA += montoAct;
                    }else{
                        if(tipoFactura == 'b'){
                            acuB += montoAct;
                        } else{
                            acuC += montoAct;
                        }
                    }
                    if(mes == 8){
                        if(b == 0){
                            menorCompra = montoAct;
                            b = 1;
                            prodMin = numProd;
                        } else{
                            if(montoAct < menorCompra){
                                menorCompra = montoAct;
                                prodMin = numProd;
                            }
                        }
                    }
                    contD++;
                    if(cant > max){
                        max = cant;
                        numProdMax = numProd;
                    }

                    Console.WriteLine("ingrese el numero de proveedor: ");
                    numProv = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el mes: ");
                    mes = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el tipo de factura: ");
                    tipoFactura = char.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el numero de producto: ");
                    numProd = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad comprada: ");
                    cant = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el precio por unidad");
                    precioUnit = float.Parse(Console.ReadLine());
                }
                Console.WriteLine("El monto máximo que se le realizo al proveedor " + numProvAct + " fue de $" + montoMayor);
                Console.WriteLine("La cantidad de compras que se le realizo fue de " + contD);
            }

            Console.WriteLine("Inversion total del año: factura A: " + acuA + " factura B: " + acuB + " factura C: " + acuC);
            Console.WriteLine("La compra con menor monto registrada en el mes de agosto fue de " + menorCompra + " del producto " + prodMin);
            Console.WriteLine("Las cantidades que mas se compraron de un producto fueron " + max + "y fue el producto " + numProdMax);
        }
    }
}
