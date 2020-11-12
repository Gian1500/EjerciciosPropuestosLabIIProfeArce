using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Documento: Imprimible
    { 
        public void imprimir()
        {
            Console.WriteLine("Soy un documento de word");
        }
    }
}
