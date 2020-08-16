using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            string entrada = "";
            int a = 0, b = 0, resultado = 0;

            //Leemos una cadena
            Console.WriteLine("Escribe tu nombre");
            entrada = Console.ReadLine();

            Console.WriteLine("Hola {0}, como estas?", entrada);

            //Leemos dos valores y los sumamos

            Console.WriteLine("Dame un entero: ");
            entrada = Console.ReadLine();

            //Convertimos la cadeana a entero

            a = Convert.ToInt32(entrada);
            Console.Write("Dame otro numero entero: ");
            entrada = Console.ReadLine();

            //Convertimos la cadena a entero

            b = Convert.ToInt32(entrada);

            //Sumamos los valores
            resultado = a + b;

            //Mostramos el resultado
            Console.WriteLine("El resultado es {0}", resultado);
            Console.ReadKey();

        }
    }
}
