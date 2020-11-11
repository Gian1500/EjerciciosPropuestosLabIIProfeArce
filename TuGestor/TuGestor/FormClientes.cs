using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TuGestor
{
    public partial class FormClientes : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        public FormClientes()
        {

            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevocliente_Click(object sender, EventArgs e)
        {
            cn.InsertarCliente(txt_nombre.Text, txt_dni.Text, txt_direccion.Text, txt_seccion.Text, txt_telefono.Text);
            dataGridView1.DataSource= cn.ConsultaDT();
            
        }

     

        private void btn_eliminarcliente_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text=="")
            {
                MessageBox.Show("Ingrese un DNI para Borrar");
            }
            else
            {
                cn.EliminarCliente(txt_dni.Text);
                dataGridView1.DataSource = cn.ConsultaDT();
            }
           
        }

        private void compruebaSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
