using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz2
{
    class TorreDeControl
    {
        List<Volador> voladores = new List<Volador>();

        public void vuelenTodos()
        {
            foreach(Volador v in voladores)
            {
                v.volador();
            }
        }

        public void agregarVolador(Volador unVolable)
        {
            voladores.Add(unVolable);
        }
    }
}
