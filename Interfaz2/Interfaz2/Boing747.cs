using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz2
{
    class Boing747:Volador
    {
        public int hsVuelo;

        public void volador()
        {
            hsVuelo += 13;
            Console.WriteLine("Estoy volando como un avión...");
        }
    }
}
