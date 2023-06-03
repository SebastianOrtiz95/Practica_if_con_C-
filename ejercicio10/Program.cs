using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si
            //son todos iguales entre sí, caso contrario, no emitir nada.

            double n1,n2,n3,n4;
            Console.WriteLine("ingrese 4 numeros: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            n4 = double.Parse(Console.ReadLine());

            if (n1==n2 && n2==n3 && n3==n4)
            {
                Console.WriteLine("todos los numeros son iguales");
            }
            else
            {
                Console.WriteLine("");
            }
            Console.ReadKey();


        }
    }
}
