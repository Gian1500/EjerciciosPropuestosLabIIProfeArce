using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
       

namespace Datos
{
    public class ConexionSQL
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=TuGestor; Uid=root; Pwd=1234");

        public int consultaLogin(string Usuario, string Contraseña)
        {
            int count;

            conexion.Open();

            string Query = "Select Count(*) From Usuarios where Usuario='"+ Usuario + "'" + "and Contraseña='" + Contraseña + "'";

            MySqlCommand cmd = new MySqlCommand(Query, conexion);

            count = Convert.ToInt32(cmd.ExecuteScalar());

            conexion.Close();

            return count;
            
        }

        public DataTable ConsultarTablaClientes()
        {

           MySqlCommand cmd = new MySqlCommand("select * from Clientes", conexion);
           MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
           DataTable tablaClientes = new DataTable();
           mySqlDataAdapter.Fill(tablaClientes);

           return tablaClientes;

            
        }

        public int InsertarCliente(string nombre, string dni, string direccion, string seccion, string telefono)
        {
            int flag = 0;
            
            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("insert into Clientes values('" + nombre + "','" + dni + "','" + direccion
                + "','" + seccion + "','" + telefono + "')",conexion);

            flag = cmd.ExecuteNonQuery();

            conexion.Close();

            return flag;
        }

       

        public int EliminarCliente(string dni)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("Delete from Clientes where dni='" + dni + "'" , conexion);

            flag = cmd.ExecuteNonQuery();

            conexion.Close();

            return flag;
        }

        public DataTable ConsultarTablaInventario()
        {

            MySqlCommand cmd = new MySqlCommand("select * from Inventario", conexion);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable tablaInventario = new DataTable();
            mySqlDataAdapter.Fill(tablaInventario);

            return tablaInventario;


        }

        public int InsertarProducto(int codigo, string nombre,int stock, double pUnitario, double descuento, double pNeto)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("insert into Inventario values('" + codigo + "','" + nombre + "','" + stock + "','"
                + pUnitario + "','"+ descuento + "','" + pNeto + "')", conexion);

            flag = cmd.ExecuteNonQuery();

            conexion.Close();

            return flag;
        }



        public int EliminarProducto(int codigo)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("Delete from Inventario where codigo='" + codigo + "'", conexion);

            flag = cmd.ExecuteNonQuery();

            conexion.Close();

            return flag;
        }

        public DataTable ConsultarTablaVentas()
        {

            MySqlCommand cmd = new MySqlCommand("select * from Inventario", conexion);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable tablaInventario = new DataTable();
            mySqlDataAdapter.Fill(tablaInventario);

            return tablaInventario;


        }

        public int AgregarVenta(int codigo, int cantidad)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd1 = new MySqlCommand("Select Stock from Inventario where Codigo={0}",conexion);

            MySqlDataReader cant = cmd1.ExecuteReader();

            cantidad = cantidad - Convert.ToInt32(cant);

            MySqlCommand cmd = new MySqlCommand("Update Inventario set Stock='"+cantidad+ "'where Codigo='"+codigo+"'", conexion);

            flag = cmd.ExecuteNonQuery();

            conexion.Close();

            return flag;
        }
    }
}
