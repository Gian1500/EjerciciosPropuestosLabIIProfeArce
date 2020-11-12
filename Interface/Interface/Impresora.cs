using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Impresora
    {
        List<Imprimible> colaDeImpresion = new List<Imprimible>();
        

        public void ImprimirTodo()
        {
            foreach(Imprimible c in colaDeImpresion)
            {
                c.imprimir();
            }
        }

        public void AgregarImprimible(Imprimible unImprimible)
        {
            colaDeImpresion.Add(unImprimible);
        }


    }
}
