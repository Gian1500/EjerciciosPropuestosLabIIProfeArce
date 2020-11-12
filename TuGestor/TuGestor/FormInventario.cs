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
    public partial class FormInventario : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        public FormInventario()
        {

            InitializeComponent();
            dataGridViewInv.DataSource = cn.ConsultaDTInv();
        }

        private void btn_AgregarInv_Click(object sender, EventArgs e)
        {
            cn.InsertarProducto(Convert.ToInt32(txt_CodigoProd.Text),txt_NombreProd.Text, Convert.ToInt32(txt_Stock.Text), 
                Convert.ToDouble(txt_PrecioC.Text),Convert.ToDouble(txt_PrecioV.Text));

            dataGridViewInv.DataSource = cn.ConsultaDTInv();
        }

        private void btn_EliminarInv_Click(object sender, EventArgs e)
        {
            if (txt_CodigoProd.Text == "")
            {
                MessageBox.Show("Ingrese un codigo del producto a eliminar");
            }
            else
            {
                cn.EliminarProducto(Convert.ToInt32(txt_CodigoProd.Text));

                dataGridViewInv.DataSource = cn.ConsultaDTInv();
            }
            
        }

        private void btn_CerrarInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_PrecioU_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void txt_Stock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
