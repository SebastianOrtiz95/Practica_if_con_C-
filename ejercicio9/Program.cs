using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Una importante marca de computadoras permite elegir cierta configuración del
            //    equipo a comprar.Para ello existe la siguiente escala de precios:
            //                   i5(1) i7(2) i9(3)
            //     8 RAM(1) USD 800 USD 900 USD 1200
            //   16 RAM(2) USD 900 USD 1000 USD 1400
            //   32 RAM(3) USD 1000 USD 1400 USD 2000
            //    el equipo viene con un disco que permite almacenar 500 GB de
            //    información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo
            //    adicional de USD 300.
            //    Hacer un programa que solicite la opción de procesador, la opción de memoria
            //    RAM, y si extiende el disco o no(ingresa 1 para extender y 0 para no extender)
            //    y calcule y emita por pantalla el monto de la máquina seleccionada.

            int procesador, memoria, disco;
            float precio;
            Console.WriteLine("ingrese la opcion de procesador");
            Console.WriteLine("1.i5\n2.i7\n3.i9");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la opcion de memoria ram");
            Console.WriteLine("1.8 RAM\n2.16 RAM\n3.32 RAM");
            memoria = int.Parse(Console.ReadLine());
            Console.WriteLine("¿amplia disco?");
            Console.WriteLine("1.SI\n0.NO");
            disco = int.Parse(Console.ReadLine());

            if (procesador==1 && memoria==1)
            {
                if (disco == 1)
                {
                    Console.WriteLine("el costo final es de USD 1100");
                }
                else
                {
                    Console.WriteLine("el costo final es de USD USD 800");
                }
            }
            if (procesador==1 && memoria==2)
            {
                if (disco==1)
                {
                    Console.WriteLine("el costo final es de USD 1200");
                }
                else
                {
                    Console.WriteLine("el costo final es de USD 900");
                }
            }
            if (procesador == 1 && memoria == 3)
            {
                if (disco == 1)
                {
                    Console.WriteLine("el costo final es de USD 1300");
                }
                else
                {
                    Console.WriteLine("el costo final es de USD USD 1000");
                }
            }
            if (procesador == 2 && memoria == 1)
            {
                if (disco == 1)
                {
                    Console.WriteLine("el costo final es de USD 1200");
                }
                else
                {
                    Console.WriteLine("el costo final es de USD USD 900");
                }
            }
            if (procesador == 2 && memoria == 2)
            {
                if (disco == 1)
                {
                    Console.WriteLine("el costo final es de USD 1300");
                }
                else
                {
                    Console.WriteLine("el costo final es de USD USD 1000");
                }
            }
            if (procesador == 2 && memoria == 3)
            {
                if (disco == 1)
                {
                    Console.WriteLine("el costo final es de USD 1700");
                }
                else
                {
                    Console.WriteLine("el costo final es de USD USD 1400");
                }
            }
            if (procesador == 3 && memoria == 1)
            {
                if (disco == 1)
                {
                    Console.WriteLine("el costo final es de USD 1500");
                }
                else
                {
                    Console.WriteLine("el costo final es de USD USD 1200");
                }
            }
            if (procesador == 3 && memoria == 2)
            {
                if (disco == 1)
                {
                    Console.WriteLine("el costo final es de USD 1700");
                }
                else
                {
                    Console.WriteLine("el costo final es de USD USD 1400");
                }
            }
            if (procesador == 3 && memoria == 3)
            {
                if (disco == 1)
                {
                    Console.WriteLine("el costo final es de USD 2300");
                }
                else
                {
                    Console.WriteLine("el costo final es de USD USD 2000");
                }
            }

            Console.ReadKey();
        }
    }
}
