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
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarN s = new GenerarN();
            DateTime fecha=dateTimePicker1.Value.Date;
            if (s.existe(fecha))
            {
                MessageBox.Show("Esta Noimna ya esta generada");
                return;
            }
            else
            {
                MessageBox.Show(s.Generar(fecha));
            }
        }
    }
}
