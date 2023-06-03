using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar por teclado la longitud de los tres lados de un
            //triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo
            //de triángulo corresponde:
            //  a.Equilátero: cuando los tres lados sean iguales.
            //  b.Isósceles: cuando dos de los tres lados sean iguales.
            //  c.Escaleno: cuando todos los lados sean distintos.

            int l1, l2, l3;
            bool aux=false; 
            Console.WriteLine("ingrese la longitud de los tres lados del triangulo: ");
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());
            l3 = int.Parse(Console.ReadLine());
            if (l1==l2 && l2==l3 && l3==l1)
            {
                Console.WriteLine("Equilatero");
                aux=true;
            }
            if (l1!=l2 && l2!=l3 && l3!=l1)
            {
                Console.WriteLine("Escaleno");
                aux = true;
            }
            if (aux==false)
            {
                Console.WriteLine("Isosceles");
            }

            Console.ReadKey();
        }
    }
}
