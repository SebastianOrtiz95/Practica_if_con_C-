using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El negocio de desinfectante antes mencionado vende además detergente
            //suelto, y los precios se aplican según la siguiente escala:
            // a. 25 ARS por litro los primeros 50 litros.
            // b. 20 ARS por litro si la venta es de 51 a 200 litros.
            // c. 15 ARS por litro si la venta es de 201 a 500 litros.
            // d. 10 ARS por litro si la venta es de más de 500 litros.
            //Además, si paga en efectivo, tiene un adicional del 10 % sobre el importe final.
            //Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago
            //(ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) y calcule
            //y emita por pantalla el monto final a abonar por el cliente

            double litrosVendidos, formaPago,precio=0,precioFinal;
            Console.WriteLine("ingrese los litros vendidos");
            litrosVendidos = int.Parse(Console.ReadLine());
            if (litrosVendidos>500)
            {
                precio = litrosVendidos * 10;
            }
            if (litrosVendidos>200 && litrosVendidos<=500)
            {
                precio = litrosVendidos * 15;
            }
            if (litrosVendidos>50 && litrosVendidos<=200)
            {
                precio = litrosVendidos * 20;
            }
            if (litrosVendidos<=50)
            {
                precio = litrosVendidos * 25;
            }
            Console.WriteLine("elija su forma de pago");
            Console.WriteLine("0.otros\n1.efectivo ");
            formaPago = double.Parse(Console.ReadLine());  
            if (formaPago==1)
            { 
            
               precioFinal = precio * 0.90;
                Console.WriteLine("el precio final en efectivo es de " + precioFinal);
            }
            else
            {
                Console.WriteLine("el precio final es de " + precio);
            }

            Console.ReadKey();
        }
    }
}
