using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y luego mostrarlos ordenados
            //de menor a mayor.

            int n1, n2, n3,mayor=0,medio=0,menor = 0;
            bool aux = false;
            Console.WriteLine("ingrese 3 numeros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (n1<n2 && n2<n3)
            {
                Console.WriteLine(n1 + "\n" + n2 + "\n" + n3 );
                aux = true;
            }
            if (n1>n2 && n1>n3)
            {
                mayor = n1;
                if (n2>n3)
                {
                    medio = n2;
                    menor = n3;
                }
                else
                {
                    menor = n3;
                    menor = n2;
                }
            }
            if (n2>n1 && n2>n3)
            {
                mayor = n2;
                if (n1>n3)
                {
                    medio = n1;
                    menor = n3;
                }
                else
                {
                    medio = n3;
                    menor = n1;
                }
            }
            if (n3 > n2 && n3 > n1)
            {
                mayor = n3;
                if (n2 > n1)
                {
                    medio = n2;
                    menor = n1;
                }
                else
                {
                    medio = n1;
                    menor = n2;
                }
            }
            if (aux==false)
            {
              Console.WriteLine("");
              Console.WriteLine(menor);
              Console.WriteLine(medio);
              Console.WriteLine(mayor);
            }


            Console.ReadKey();
        }
    }
}
