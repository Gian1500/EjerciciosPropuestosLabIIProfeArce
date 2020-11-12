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
    public partial class FormVentas : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        private double resultado = 0 ;
        private DataTable dt;

        public FormVentas()
        {
            InitializeComponent();
            dataGridViewVentas.DataSource = cn.ConsultaDTVentas();

            dt = new DataTable();
            dt.Columns.Add("Producto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio Unitario");
            dt.Columns.Add("Total");

            dataGridViewCarrito.DataSource = dt;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregarVenta_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            row["Producto"] = "";
            row["Cantidad"] = txt_cantidadProd.Text;
            row["Precio Unitario"] = cn.consultaVenta(Convert.ToInt32(txt_busquedaCod.Text)); 
            row["Total"]= cn.consultaVenta(Convert.ToInt32(txt_busquedaCod.Text)) * Convert.ToInt32(txt_cantidadProd.Text);

            dt.Rows.Add(row);

            cn.AgregarVenta(Convert.ToInt32(txt_busquedaCod.Text), Convert.ToInt32(txt_cantidadProd.Text));

            dataGridViewVentas.DataSource = cn.ConsultaDTVentas();



            resultado = resultado + cn.consultaVenta(Convert.ToInt32(txt_busquedaCod.Text))* Convert.ToDouble(txt_cantidadProd.Text);

            label_total.Text = resultado.ToString();


        }

        private void btn_CerrarV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
