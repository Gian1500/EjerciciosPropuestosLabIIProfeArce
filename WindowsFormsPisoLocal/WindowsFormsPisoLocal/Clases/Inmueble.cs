using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPisoLocal.Clases
{
    abstract class Inmueble
    {
        protected String direccion;
        protected int mt;
        protected bool esNuevo;
        protected double precioBase;

        protected Inmueble(string direccion, int mt, bool esNuevo, double precioBase)
        {
            this.direccion = direccion;
            this.mt = mt;
            this.esNuevo = esNuevo;
            this.precioBase = precioBase;
        }


        public abstract double calcularPrecio(double precioBase);
        
       
        }
    }

