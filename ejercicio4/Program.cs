using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos
            //dependiendo de la cantidad de litros vendidos según la siguiente escala:
            // a.Si vende menos de 100 litros, no hay descuento.
            // b.Si vende entre 101 y 300 litros, el descuento es del 10 %.
            // c.Si vende entre 301 y 500 litros, el descuento es del 15 %.
            // d.Finalmente, si la venta es de más de 500 litros, el descuento es del 25 %.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la
            //cantidad de litros vendidos y calcule y emita el importe con el descuento
            //aplicado.

            double importeTotal, importeFinal, cantLitros;
            Console.WriteLine("ingrese la cantidad de litros: ");
            cantLitros = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el importe total: ");
            importeTotal = double.Parse(Console.ReadLine());
            if (cantLitros>500)
            {
                importeFinal = importeTotal * 0.75;
                Console.WriteLine(" el importe a pagar es : " + importeFinal);
            }
            if (cantLitros>300 && cantLitros<501)
            {
                importeFinal = importeTotal * 0.85;
                Console.WriteLine("el importe a pagar es: " + importeFinal);
            }
            if (cantLitros>100 && cantLitros<300)
            {
                importeFinal = importeTotal * 0.90;
                Console.WriteLine("el importe a pagar es: " + importeFinal);
            }
            if (cantLitros<=100)
            {
                Console.WriteLine("el importe a pagar es: " + importeTotal);
            }

            Console.ReadKey();
        }
    }
}
