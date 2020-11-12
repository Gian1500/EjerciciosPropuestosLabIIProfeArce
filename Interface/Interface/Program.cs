using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato c1 = new Contrato();
            Foto f1 = new Foto();
            Documento d1 = new Documento();
            Impresora i1 = new Impresora();

            i1.AgregarImprimible(c1);
            i1.AgregarImprimible(f1);
            i1.AgregarImprimible(d1);

            i1.ImprimirTodo();
            Console.ReadKey();
        }
    }
}
