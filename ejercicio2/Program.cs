using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de dos números y luego calcular:
            //   a.La resta si el primero es mayor que el segundo.
            //   b.La suma si son iguales.
            //   c.El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int n1,n2,resta,suma,producto;
            Console.WriteLine("ingrese dos numeros");
            n1=int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if (n1>n2)
            {
                resta=n1 - n2;
                Console.WriteLine("el resultado es: " + resta);
            }
            if (n1==n2)
            {
                suma=n1 + n2;
                Console.WriteLine("el resultado es: " + suma);
            }
            if (n1<n2)
            {
                producto = n1 * n2;
                Console.WriteLine("el resultado es " + producto);
            }
            Console.ReadKey();  
        }
    }
}
