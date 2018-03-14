using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NominaGH.View;
using NominaGH.Reportes;



namespace NominaGH
{
    public partial class Form1 : Form
    {
        public static Form1 miObjeto;
        public Form1()
        {
            InitializeComponent();
            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.FromArgb(44, 62, 80);
                }


            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados frm = new Empleados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void generarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nomina frm = new Nomina();
            frm.MdiParent = this;
            frm.Show();
        }

        private void empleadosNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarNomina frm = new EditarNomina();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nominaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteNominaCompleta frm = new ReporteNominaCompleta();
            //reportes frm = new reportes();
            
            frm.MdiParent = this;
            frm.Show();
        }

        private void papelitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteNominaPeque frm = new ReporteNominaPeque();
            frm.MdiParent = this;
            frm.Show();
        }

        private void parteAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteNominaAtras frm = new ReporteNominaAtras();
            //reportes frm = new reportes();
           
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empleadosToolStripMenuItem.Enabled = false;
            editarToolStripMenuItem.Enabled = false;
            gENERARToolStripMenuItem.Enabled = false;
            reportesToolStripMenuItem.Enabled = false;
            Login frm = new Login();
            frm.MdiParent = this;
            frm.Show();
            miObjeto = this;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empleadosToolStripMenuItem.Enabled = false;
            editarToolStripMenuItem.Enabled = false;
            gENERARToolStripMenuItem.Enabled = false;
            reportesToolStripMenuItem.Enabled = false;
            Login frm = new Login();
            frm.MdiParent = this;
            frm.Show();
            miObjeto = this;
        }
    }
}
