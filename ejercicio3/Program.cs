using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar dos números.Si el segundo es distinto de
            //cero, calcular la división del primero por el segundo y mostrar el resultado por
            //pantalla; caso contrario, emitir un cartel aclarando que no se puede dividir por
            //cero.

            float n1, n2,resultado;
            Console.WriteLine("ingrese dos numeros");
            n1= float.Parse(Console.ReadLine());
            n2= float.Parse(Console.ReadLine());
            if (n2!=0)
            {
                resultado = n1 / n2;
                Console.WriteLine("el resultado es: " + resultado);
            }
            else
            {
                Console.WriteLine("no se puede dividir por cero");
            }
            Console.ReadKey();
        }
    }
}
