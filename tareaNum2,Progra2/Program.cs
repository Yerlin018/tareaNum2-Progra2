using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        //static string[] nombre = new string[10];
        //static string[] cedula = new string[10];
        //static int[] codigo = new int[10];
        //static int[] canthoras = new int[10];
        //static int[] preciohora = new int[10];
        //static float[] SalarioOrdinario = new float[10];
        //static double[] Aumentos = new double[10];
        //static double[] SalarioBruto = new double[10];
        //static double[] Deducciones = new double[10];
        //static double[] SalarioNeto = new double[10];

        ////Variables para el Ejercicio de Ventas

        static int cantEntradas;
        static string Nomb;
        static string Ncedula;
        static string Nfactura;
        static double subtotal = 0;
        static double total = 0;
        static int cont1 = 0;
        static int cont2 = 0;
        static int cont3 = 0;
        static int[] localidad = new int[4];
        static double[] precios = new double[4];

        static void Main(string[] args)
        {
            //    Console.WriteLine("Ejercicio 1");
            //    Console.WriteLine("Calculo de aumentos salariales");
            //    int CantPersonas = 0;
            //    Console.WriteLine("Digite la cantidad de empleados a consultar sus aumentos");
            //    CantPersonas=int.Parse(Console.ReadLine());

            //    // solicito los datos y los almaceno en arreglos
            //    int i = 0;
            //    while (i < CantPersonas)
            //    {
            //        Console.WriteLine($"Digite el nombre del empleado {i+1} ");
            //        nombre[i] = Console.ReadLine();
            //        Console.WriteLine($"Digite la cedula del empleado:{nombre[i]} ");
            //        cedula[i] = Console.ReadLine();
            //        Console.WriteLine($"Digite el codigo del empleado:{nombre[i]} ");
            //        codigo[i]=int.Parse(Console.ReadLine());
            //        Console.WriteLine($"Digite la cantidad de horas trabajadas por el empleado:{nombre[i]} ");
            //        canthoras[i] = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"Digite el precio por hora del empleado:{nombre[i]} ");
            //        preciohora[i] = int.Parse(Console.ReadLine());
            //        SalarioOrdinario[i] = canthoras[i] * preciohora[i];
            //        i++;
            //    }
            //    // Arreglo de aumentos, Deducciones y neto


            //    int x = 0;
            //    while (x < CantPersonas)
            //    {
            //        if (codigo[x] == 1)
            //        {
            //            Aumentos[x] = SalarioOrdinario[x] * 0.15;
            //            SalarioBruto[x]= SalarioOrdinario[x]+Aumentos[x];
            //            Deducciones[x] = SalarioBruto[x] * 0.0917;
            //            SalarioNeto[x] = SalarioBruto[x] - Deducciones[x];
            //        }
            //        else
            //        {
            //            if (codigo[x] == 2)
            //            {
            //                Aumentos[x] = SalarioOrdinario[x] * 0.10;
            //                SalarioBruto[x] = SalarioOrdinario[x] + Aumentos[x];
            //                Deducciones[x] = SalarioBruto[x] * 0.0917;
            //                SalarioNeto[x] = SalarioBruto[x] - Deducciones[x];
            //            }
            //            else
            //            {
            //                if (codigo[x] == 3)
            //                {
            //                    Aumentos[x] = SalarioOrdinario[x] * 0.05;
            //                    SalarioBruto[x] = SalarioOrdinario[x] + Aumentos[x];
            //                    Deducciones[x] = SalarioBruto[x] * 0.0917;
            //                    SalarioNeto[x]= SalarioBruto[x]-Deducciones[x];

            //                }
            //                else
            //                {
            //                    Console.WriteLine("Su codigo no es valido o no tiene aumentos");
            //                }
            //            }

            //        }x++;
            //    }
            //    // Imprimir los datos de cada
            //    x = 0;
            //    while (x<CantPersonas)
            //    {
            //        Console.WriteLine($"Nombre: {nombre[x]}");
            //        Console.WriteLine($" Cedula: {cedula[x]}");
            //        Console.WriteLine($" Tipo de empleado: {codigo[x]}");
            //        Console.WriteLine($" Cantidad de horas: {canthoras[x]}");
            //        Console.WriteLine($" Salario por hora: {preciohora[x]}");
            //        Console.WriteLine($" Salario ordinario: {SalarioOrdinario[x]}");
            //        Console.WriteLine($" Aumento : {Aumentos[x]}");
            //        Console.WriteLine($" Salario Bruto: {SalarioBruto[x]}");
            //        Console.WriteLine($" Deducciones CCSS: {Deducciones[x]}");
            //        Console.WriteLine($" Salario Neto: {SalarioNeto[x]}");
            //         x++;

            ////    } 

            //    



            Console.WriteLine("Sistema de enventas");
            Console.WriteLine("Costa Rica vrs Mexico");
            Console.WriteLine("--------------------");


            //Validar la cantidad de entrada
            Console.WriteLine("Digite el numero de la factura ");
            Nfactura = Console.ReadLine();
            Console.WriteLine("Digite el numero de cedula ");
            Ncedula = Console.ReadLine();
            Console.WriteLine("Digite el nombre de comprador}");
            Nomb = Console.ReadLine();

            Console.WriteLine("Indique la cantidad de entradas que desea comprar");
            cantEntradas = int.Parse(Console.ReadLine());
            while (cantEntradas < 1 || cantEntradas > 4)
            {
                Console.WriteLine("Debe comprar entre 1 y 4 entradas ");
                Console.WriteLine("Indique la cantidad de entradas que desea comprar");
                cantEntradas = int.Parse(Console.ReadLine());
            }

            // Solicitar la localidad para cada entrada
            int i = 0;
            while (i < cantEntradas)
            {
                Console.WriteLine($"Informacion sobre la entrada {i + 1} ");
                Console.WriteLine("Indique 1. Si la desea en el Sol Norte/Sur  ");
                Console.WriteLine("Indique 2. Si la desea en  Sombra Este/Oeste ");
                Console.WriteLine("Indique 3.Si la desea en Preferencial");
                localidad[i] = int.Parse(Console.ReadLine());
                i++;
            }

            // asignar precio por entra a una arreglo
            int x = 0;
            while (i < cantEntradas)
            {
                if (localidad[x] == 1)
                {
                    precios[x] = 10500;
                }
                else
                {
                    if (localidad[x] == 2)
                    {
                        precios[x] = 20500;
                    }
                    else
                    {
                        if (localidad[x] == 3)
                        {
                            precios[x] = 25500;
                        }
                    }
                }
                x++;
            }

            i = 0;
            while (i < cantEntradas) ;
            {
                Console.WriteLine(precios[i]);
                i++;
            }


            //// calcular el subtotal

            //i = 0;
            //while (i < cantEntradas);
            //{
            //    subtotal += precios[i];
            //    i++;
            //}

            //// calcular total
            //total = subtotal+1000;

            ////Imprimir la localidad y contar por region

            //i = 0;

            //while (i < cantEntradas)
            //{
            //    if (localidad[i] == 1)
            //    {
            //        //Console.WriteLine($"La localidad de la entrada {i + 1} es sol Norte Sur, precio 10500");
            //        cont1 += 1 ;
            //    }
            //    else { 
            //        if (localidad[i] == 2)
            //            {
            //            //Console.WriteLine($"La localidad de la entrada {i + 1} es Sombra Este Oeste,precio 20500");
            //            cont2 += 1;
            //        }
            //        else
            //        {
            //            if (localidad[i] == 3)
            //            {
            //              //  Console.WriteLine($"La localidad de la entrada {i + 1} es Sombra Este Oeste, precio 25500");
            //                cont3 += 1;
            //            }
            //        }
            //    }




            //    i++;
            //}

            //// Imprimir todo
            //Console.WriteLine($" Numero de Factura: {Nfactura}");
            //Console.WriteLine($" Cedula: {Ncedula}");
            //Console.WriteLine($"Nombre del comprador: {Nomb}");
            //Console.WriteLine($"Calntidad de entradas en Sol Norte sur: {cont1}");
            //Console.WriteLine($"Calntidad de entradas en Sombra Este Oeste: {cont2}");
            //Console.WriteLine($"Calntidad de entradas en Preferencia: {cont3}");
            //Console.WriteLine($"Subtotal de la compra:{subtotal}");
            //Console.WriteLine("Cargos por servicios :1 000");
            //Console.WriteLine($"Total de la compra:{subtotal}");

            ////        Console.WriteLine($" Tipo de empleado: {codigo[x]}");



            Console.Read();
        }
    }

}
