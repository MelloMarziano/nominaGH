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
using NominaGH.Controls;

namespace NominaGH.View
{
    public partial class EditarNomina : Form
    {
        public EditarNomina()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string _nombre = txtNombre.Text ;
            ltbListado.Items.Clear();
            

            if (_nombre != string.Empty)
            {
                using (grupohie_nominaEntities db = new grupohie_nominaEntities())
                {
                    var resultado = db.empleados.Where(x => x.nombre.Contains(_nombre)).ToList();


                    foreach (var p in resultado)
                    {

                        ltbListado.Items.Add(p.nombre);
                    }

                }

            }
        }

        private void ltbListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = ltbListado.SelectedItem.ToString();
            MessageBox.Show(nombre);
            using (grupohie_nominaEntities db = new grupohie_nominaEntities())
            {
                var resultado = db.resultados.Where(x => x.nombre == nombre).ToList();

                foreach (var i in resultado)
                {

                    txtnombreE.Text = i.nombre;
                    txtcedula.Text = i.cedula;
                    txtPrestamo.Text = i.prestamo.ToString();
                    txtOtros.Text = i.otros.ToString();
                    txtAlmacen.Text = i.desayuno.ToString();
                    txtmayo.Text = i.san_mayo.ToString ();
                    txtId.Text = i.id.ToString();
                    txtsueldoB.Text = i.sueldo_bruto.ToString();
                    txtExtra.Text = i.horas_extras.ToString();
                    txtNombre.Text = string.Empty;
                    ltbListado.Items.Clear();
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editarNomina s = new editarNomina();
            int id=Convert.ToInt32(txtId.Text);
            if (txtId.Text != string.Empty)
            {
                decimal prestamo = Convert.ToDecimal(txtPrestamo.Text);
                decimal almacen = Convert.ToDecimal(txtAlmacen.Text);
                decimal otros = Convert.ToDecimal(txtOtros.Text);
                decimal mayo = Convert.ToDecimal(txtmayo.Text);
                DateTime fecha = dateTimePicker1.Value.Date;
                if (s.existe(fecha))
                {
                    MessageBox.Show(s.Modificar(id, fecha, mayo, prestamo, almacen, otros));

                    txtAlmacen.Text = string.Empty;
                    txtcedula.Text = string.Empty;
                    txtId.Text = string.Empty;
                    //txtNombre.Text = string.Empty;
                    txtnombreE.Text = string.Empty;
                    txtOtros.Text = string.Empty;
                    txtPrestamo.Text = string.Empty;
                    txtmayo.Text = string.Empty;
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show("ESTA FECHA DE NOMINA NO ESTA GENERADA");
                }
                
            }
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             editarNomina s = new editarNomina();
            int id=Convert.ToInt32(txtId.Text);
            if (txtId.Text != string.Empty)
            {
                decimal prestamo = Convert.ToDecimal(txtPrestamo.Text);
                decimal almacen = Convert.ToDecimal(txtAlmacen.Text);
                decimal otros = Convert.ToDecimal(txtOtros.Text);
                decimal mayo = Convert.ToDecimal(txtmayo.Text);
                DateTime fecha = dateTimePicker1.Value.Date;
                if (s.existe(fecha))
                {
                    MessageBox.Show(s.Modificar(id, fecha, mayo, prestamo, almacen, otros));

                    txtAlmacen.Text = string.Empty;
                    txtcedula.Text = string.Empty;
                    txtId.Text = string.Empty;
                    //txtNombre.Text = string.Empty;
                    txtnombreE.Text = string.Empty;
                    txtOtros.Text = string.Empty;
                    txtPrestamo.Text = string.Empty;
                    txtmayo.Text = string.Empty;
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show("ESTA FECHA DE NOMINA NO ESTA GENERADA");
                }
            }
        }
    }
}
