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

        public int InsertarProducto(int codigo, string nombre,int stock, double pCosto, double pVenta)
        {
            int flag = 0;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("insert into Inventario values('" + codigo + "','" + nombre + "','" + stock + "','"
                + pCosto + "','" + pVenta + "')", conexion);

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
            int cant = 0;


            MySqlCommand cmd1 = new MySqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Select Stock from Inventario where Codigo='"+codigo+"'";
            cmd1.Connection = conexion;

            conexion.Open();

            MySqlDataReader dr = cmd1.ExecuteReader();

            dr.Read();

            cant = dr.GetInt32(0);

            conexion.Close();

            cant = cant - cantidad;

            conexion.Open();

            MySqlCommand cmd = new MySqlCommand("Update Inventario set Stock='"+cant+ "'where Codigo='"+codigo+"'", conexion);

            flag = cmd.ExecuteNonQuery();

            conexion.Close();

            return flag;
        }

        public double consultaVenta(int codigo)
        {
            double res=0;

            conexion.Open();

            string query= "select * from Inventario where Codigo='"+codigo+"'";

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader reg = cmd.ExecuteReader();

            reg.Read();

            res=Convert.ToDouble(reg["Precio Venta"]);

            conexion.Close();

            return res;


        }   
    }   
}
