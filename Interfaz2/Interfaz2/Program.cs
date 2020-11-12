using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato p1 = new Pato();
            Boing747 a1 = new Boing747();
            Superman s1 = new Superman();
            TorreDeControl t1 = new TorreDeControl();

            t1.agregarVolador(p1);
            t1.agregarVolador(a1);
            t1.agregarVolador(s1);

            t1.vuelenTodos();
            Console.ReadKey();
        }
    }
}
