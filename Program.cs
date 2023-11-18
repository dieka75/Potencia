using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1, potencia, resultado = 1;
            byte i;

            Console.WriteLine("Escriba un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba la potencia: ");
            potencia = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i <= potencia; i++)
            {
                resultado = resultado * num;
            }
            Console.WriteLine("el resultado es {0}", resultado);

        }
    }
}
