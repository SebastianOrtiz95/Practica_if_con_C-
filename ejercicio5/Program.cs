using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de las notas del primer parcial y del
            //segundo parcial de una alumna de programación. El programa deberá analizar
            //las notas y emitir la situación de la alumna según la siguiente escala:
            //  a.Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
            //  b.Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales(se
            //  aprueba con 6 o más), emitir “rinde examen final”.
            //  c.Si tiene menos de 6 en alguno de los dos parciales, emitir “debe
            //  recuperar”.
            //El programa debe emitir solo un cartel, el que corresponda.

            double nota1, nota2;
            Console.WriteLine("ingrese las dos notas de los parciales");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            if (nota1<6 || nota2<6)
            {
                Console.WriteLine("debe recurar");
            }
            else
            {
                if (nota1>=8 && nota2>=8)
                {
                    Console.WriteLine("aprobacion directa");
                }
                else
                {
                    Console.WriteLine("rinde examen final");
                }
            }
            
            Console.ReadKey();
        }
    }
}
