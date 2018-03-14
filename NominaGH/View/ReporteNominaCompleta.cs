using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NominaGH.Models;
using NominaGH.Controls;
using NominaGH.Reportes;

namespace NominaGH.View
{
    public partial class ReporteNominaCompleta : Form
    {
        public ReporteNominaCompleta()
        {
            InitializeComponent();
        }

       
        

        private void ReporteNominaCompleta_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

       
       
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
                        
        }
/*
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string _sucursal = cbosucursal.Text;

            reporteCompleto s = new reporteCompleto();
            reportes frm = new reportes();
            if (s.existe(_sucursal))
            {
                using (grupohie_nominaEntities db = new grupohie_nominaEntities())
                {
                    var resultados = db.resultados.Where(x => x.sucursal == _sucursal).ToList();
                    frm.resultadosBindingSource.DataSource = resultados;

                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Esta Sucursal no tiene nada Generado Actualmente");
            }
        }

 * 
 * */
        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _sucursal = cbosucursal.Text;
            DateTime _fecha = dateTimePicker1.Value.Date;

            reporteCompleto s = new reporteCompleto();
            reportes frm = new reportes();
            if (s.existe(_sucursal,_fecha))
            {
                using (grupohie_nominaEntities db = new grupohie_nominaEntities())
                {
                    var resultados = db.resultados.Where(x => x.sucursal == _sucursal && x.fecha == _fecha).ToList();
                    frm.resultadosBindingSource.DataSource = resultados;

                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Esta Sucursal no tiene nada Generado Actualmente");
            }
        }

        private void linkLabel2_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string _sucursal = cbosucursal.Text;
            DateTime _fecha = dateTimePicker1.Value.Date;

            reporteCompleto s = new reporteCompleto();
            reportes frm = new reportes();
            if (s.existe(_sucursal, _fecha))
            {
                using (grupohie_nominaEntities db = new grupohie_nominaEntities())
                {
                    var resultados = db.resultados.Where(x => x.sucursal == _sucursal && x.sucursal2==_sucursal  && x.fecha == _fecha).ToList();
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
