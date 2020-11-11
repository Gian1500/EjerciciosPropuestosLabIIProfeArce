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

        public FormVentas()
        {
            InitializeComponent();
            dataGridViewVentas.DataSource = cn.ConsultaDTVentas(); 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregarVenta_Click(object sender, EventArgs e)
        {
            cn.AgregarVenta(Convert.ToInt32(txt_busquedaCod.Text), Convert.ToInt32(txt_cantidadProd.Text));
            dataGridViewVentas.DataSource = cn.ConsultaDTVentas();
        }
    }
}
