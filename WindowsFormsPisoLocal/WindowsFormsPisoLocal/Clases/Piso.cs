using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPisoLocal.Clases
{

    class Piso : Inmueble
    {
        private int numPiso;

        public Piso(string direccion, int mt, bool esNuevo, double precioBase,int numPiso) : base(direccion, mt, esNuevo, precioBase)
        {
            this.numPiso = numPiso;
        }

        public int NumPiso { get => numPiso; set => numPiso = value; }

        public override double calcularPrecio(double precioBase)
        {
            double precioFinal;
            double A = 0.0, B = 0.0;
            

            if (esNuevo == true)
            {
                A = A - (precioBase * 1) / 100;
            }
            else
            {
                A = A - (precioBase * 2) / 100;
            }

            if (numPiso >= 3)
            {
                B = B + (precioBase * 3) / 100;
            }

            precioFinal = precioBase + A + B;

            return precioFinal;

        }
    }
}
