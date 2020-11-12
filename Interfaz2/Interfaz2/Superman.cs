using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz2
{
    class Superman:Volador
    {
        public int experiencia;

        public void volador()
        {
            experiencia += 3;
            Console.WriteLine("Estoy volando como un campeon...");
        }

    }
}
