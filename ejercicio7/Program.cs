using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números.Luego analizar e informar por
            //pantalla si los mismos se encuentran ordenados de forma decreciente.

            int n1, n2 ,n3, n4;
            Console.WriteLine("ingrese 4 numeros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            if (n4<n3 && n3<n2 && n2<n1)
            {
                Console.WriteLine("estan ordenados de forma decreciente");
            }
            else
            {
               
              Console.WriteLine("no estan ordenados de forma decreciente");

            }
            Console.ReadKey();  
        }
    }
}
