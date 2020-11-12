using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz2
{
    class Pato:Volador
    {
        public int energia=0;

        public void volador()
        {
            energia -= 5;
            Console.WriteLine("Estoy volando como un pato... ¡Cuak!");

        }
    }
}
