using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NominaGH.Models;
using NominaGH.Reportes;
using NominaGH.Controls;

namespace NominaGH.View
{
    public partial class ReporteNominaAtras : Form
    {
        public ReporteNominaAtras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _sucursal = cbosucursal.Text;
            //string _sucursal2=cboSucursal2.Text ;
            DateTime _fecha = dateTimePicker1.Value.Date;

            reporteCompleto s = new reporteCompleto();
            reportes frm = new reportes();
            if (s.existe(_sucursal, _fecha))
            {
                using (grupohie_nominaEntities db = new grupohie_nominaEntities())
                {
                    var resultados = db.resultados.Where(x => x.sucursal2 == _sucursal && x.fecha == _fecha).ToList();
                    frm.resultadosBindingSource.DataSource = resultados;

                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Esta Sucursal no tiene nada Generado Actualmente");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string _sucursal = cbosucursal.Text;
            //string _sucursal2=cboSucursal2.Text ;
            DateTime _fecha = dateTimePicker1.Value.Date;

            reporteCompleto s = new reporteCompleto();
            reportes frm = new reportes();
            if (s.existe(_sucursal, _fecha))
            {
                using (grupohie_nominaEntities db = new grupohie_nominaEntities())
                {
                    var resultados = db.resultados.Where(x => x.sucursal2 == _sucursal && x.fecha == _fecha).ToList();
                    frm.resultadosBindingSource.DataSource = resultados;

                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Esta Sucursal no tiene nada Generado Actualmente");
            }
        }
    }
}
