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
    public partial class FormLogin : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        public FormLogin()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(txt_Usuario.Text,txt_Contraseña.Text)==1)
            {
                MessageBox.Show("El usuario ha sido encontrado");

                this.Hide();

                VentanaPrincipal v1 = new VentanaPrincipal();
                v1.Show();
            }
            else
            {
                MessageBox.Show("F");
            }
        }
    }
}
