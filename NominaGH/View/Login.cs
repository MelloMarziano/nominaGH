using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NominaGH.Controls;

namespace NominaGH.View
{
    public partial class Login : Form
    {
        Form1 frm = new Form1();
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;
            string clave = txtClave.Text;
            //usuarioCRUD b = new usuarioCRUD();
            CRUDusuarios b = new CRUDusuarios();
            //facturaCRUD c = new facturaCRUD();
            if (b.login(nombre, clave))
            {
                Form1.miObjeto.empleadosToolStripMenuItem.Enabled = true;
                Form1.miObjeto.editarToolStripMenuItem.Enabled = true;
                Form1.miObjeto.gENERARToolStripMenuItem.Enabled = true;
                Form1.miObjeto.reportesToolStripMenuItem.Enabled = true;
                this.Close();
               

            }
            else
            {
                MessageBox.Show("USUARIO Y/O CLAVE NO REGISTRADOS...");
                txtClave.Text = string.Empty;
                txtUsuario.Text = string.Empty;
                txtUsuario.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtClave.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtUsuario.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
