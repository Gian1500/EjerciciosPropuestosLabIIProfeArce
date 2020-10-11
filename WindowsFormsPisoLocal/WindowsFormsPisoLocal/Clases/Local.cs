using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPisoLocal.Clases
{
    class Local : Inmueble
    {
        private int numVentanas;

        public int NumVentanas { get => numVentanas; set => numVentanas = value; }

        public Local(string direccion, int mt, bool esNuevo, double precioBase, int numVentanas) : base(direccion, mt, esNuevo, precioBase)
        {
            this.numVentanas = numVentanas;
        }



        public override double calcularPrecio(double precioBase)
        {
            double precioFinal;
            double A=0.0, B = 0.0, C = 0.0;


            if (esNuevo==true)
            {
                A = A - (precioBase * 1) / 100;
            }
            else 
            {
                A = A - (precioBase * 2) / 100;
            
            }

            if (mt>50)
            {
                B = B + (precioBase * 1) / 100;
            }

            if (numVentanas <= 1)
                C = C - (precioBase * 2) / 100;
            else if (numVentanas >= 4)
                C = C + (precioBase * 2) / 100;

            precioFinal = precioBase + A + B + C;

            return precioFinal;
        }
    }
}
