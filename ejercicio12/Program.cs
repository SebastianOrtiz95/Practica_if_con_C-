using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si
            //la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int n1, n2, n3,suma,producto;
            Console.WriteLine("ingrese 3 numeros");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            suma = n1 + n2;
            producto = n2 * n3;
            if (suma>producto)
            {
                Console.WriteLine("la suma de los 2 primeros numeros es mayor al producto del segundo por el tercero");
            }
            Console.ReadKey();
        }
    }
}
