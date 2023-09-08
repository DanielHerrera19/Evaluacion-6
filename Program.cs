using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto total de su compra: ");
            string montotexto = Console.ReadLine();

            float monto= float.Parse(montotexto);
            float descuento = 0f;

            if (monto > 1000) 
            {
                descuento = monto * 0.20f;
            }
            else if (monto > 500)
            {
                descuento = monto * 0.10f;
            }
            else if (monto <= 500)
            {
                descuento = 0;
            }

            Console.WriteLine("Su descuento es de: " + descuento);
            Console.ReadKey();
        }
    }
}