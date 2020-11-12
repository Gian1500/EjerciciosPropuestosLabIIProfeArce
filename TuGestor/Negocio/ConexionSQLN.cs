using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ConexionSQLN
    {
        ConexionSQL cn = new ConexionSQL();

        public int conSQL(string User, string Pass)
        {
            return cn.consultaLogin(User, Pass);
        }

        public DataTable ConsultaDT()
        {
           return cn.ConsultarTablaClientes();
        }

        public DataTable ConsultaDTInv()
        {
            return cn.ConsultarTablaInventario();
        }

        public DataTable ConsultaDTVentas()
        {
            return cn.ConsultarTablaVentas();
        }

        public int InsertarCliente(string nombre, string dni, string direccion, string seccion, string telefono)
        {

            return cn.InsertarCliente(nombre,dni,direccion,seccion,telefono);
        }

  
        public int EliminarCliente(string dni)
        {
           

            return cn.EliminarCliente(dni);
        }

        public int InsertarProducto(int codigo, string nombre, int stock, double pCosto, double pVenta)
        {

            return cn.InsertarProducto(codigo,nombre,stock, pCosto, pVenta);
        }

        public int EliminarProducto(int codigo)
        {


            return cn.EliminarProducto(codigo);
        }

        public int AgregarVenta(int codigo, int cantidad)
        {
            return cn.AgregarVenta(codigo,cantidad);
        }

        public double consultaVenta(int codigo)
        {
            return cn.consultaVenta(codigo);
        }
    }
}
