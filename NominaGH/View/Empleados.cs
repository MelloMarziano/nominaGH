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
using NominaGH.Models;

namespace NominaGH
{
    public partial class Empleados : Form
    {
        int numero = 0;
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btndeshacer_Click(object sender, EventArgs e)
        {
            txtdireccion.Text = string.Empty;
            txtextras.Text = string.Empty;
            //txtmayo.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtocupacion.Text = string.Empty;
            txtseguro.Text = string.Empty;
            txtsueldobruto.Text = string.Empty;
            mkcedula.Text = string.Empty;
            mktelefono.Text = string.Empty;
            cboatras.Text = "--ESCOGE UNA--";
            cbosucursal.Text = "--ESCOGE UNA--";

            lblId.Visible = false;
            txtId.Visible = false;
            txtId.Text = string.Empty;
            cboatras.Enabled = false;
            cbosucursal.Enabled = false;

            chkcomida.Checked = false;
            dpentrada.Value = DateTime.Now.Date;
            dpnacimiento.Value=DateTime.Now.Date;
            mkSalida.Text = string.Empty;
            btnguardar.Enabled = false;
            btndeshacer.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnnuevo.Enabled = true;


            txtdireccion.Enabled = false;
            txtextras.Enabled = false;
            //txtmayo.Enabled = false;
            txtnombre.Enabled = false;
            txtocupacion.Enabled = false;
            txtseguro.Enabled = false;
            txtsueldobruto.Enabled = false;
            mkcedula.Enabled = false;
            mktelefono.Enabled = false;
            cbosucursal.Enabled = false;
            chkcomida.Enabled = false; ;
            dpentrada.Enabled = false;
            dpnacimiento.Enabled = false;
            mkSalida.Enabled = false;

            btnCedula.Visible = false;
            btnComida.Visible = false;
            btnDireccion.Visible = false;
            btnSueldoB.Visible = false;
            btnOcupacion.Visible = false;
            btnHE.Visible = false;
            //btnSan.Visible = false;
            btnSeguro.Visible = false;
            button1.Visible = false;
            btnnombre.Visible = false;
            btnFechaS.Visible = false;
            btnAtras.Visible = false;

            btnGuardarCambios.Visible = false;
            timer1.Stop();
           

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            txtdireccion.Text = string.Empty;
            txtextras.Text = string.Empty;
            //txtmayo.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtocupacion.Text = string.Empty;
            txtseguro.Text = string.Empty;
            txtsueldobruto.Text = string.Empty;
            mkcedula.Text = string.Empty;
            mktelefono.Text = string.Empty;
            cboatras.Text = "--ESCOGE UNA--";
            cbosucursal.Text = "--ESCOGE UNA--";
            dpentrada.Value = DateTime.Now.Date;
            dpnacimiento.Value = DateTime.Now.Date;

            lblId.Visible = false;
            txtId.Visible = false;
            txtId.Text = string.Empty;

            txtdireccion.Enabled = true;
            txtextras.Enabled = true;
            //txtmayo.Enabled = true;
            txtnombre.Enabled = true;
            txtocupacion.Enabled = true;
            txtseguro.Enabled = true;
            txtsueldobruto.Enabled = true;
            mkcedula.Enabled = true;
            mktelefono.Enabled = true;
            cbosucursal.Enabled = true;
            cboatras.Enabled = true;
            chkcomida.Enabled = true;
            dpentrada.Enabled = true;
            dpnacimiento.Enabled = true;
            mkSalida.Enabled = true;
            btnguardar.Enabled = true;
            btndeshacer.Enabled = true;
            btneditar.Visible = true;
            btneliminar.Visible = true;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre, direccion, cedula, telefono, sucursal,atrasP, ocupacion,fechaS;
            decimal sueldoB, horasE, seguroP;
            DateTime fechaE,  fechaN;
            bool comida, actual;
            DateTime fecha = DateTime.Now.Date;


            if (txtnombre.Text == string.Empty)
            {
                MessageBox.Show("Este campo no puede estar vacio");
                return;
            }

            if (txtdireccion.Text == string.Empty)
            {
                MessageBox.Show("Este campo no puede estar vacio");
                return;
            }

            if (txtocupacion.Text == string.Empty)
            {
                MessageBox.Show("Este campo no puede estar vacio");
                return;
            }

            if (txtsueldobruto.Text == string.Empty)
            {
                MessageBox.Show("Este campo no puede estar vacio");
                return;
            }



            if (txtextras.Text == string.Empty)
            {
                horasE = 0;
            }
            else
            {
                horasE = Convert.ToDecimal(txtextras.Text);
            }




           

            if (txtseguro.Text == string.Empty)
            {
                seguroP = 0;
            }
            else
            {
                seguroP = Convert.ToDecimal(txtseguro.Text);
            }


            if (fecha == dpnacimiento.Value.Date)
            {
                MessageBox.Show("Fecha de nacimiento no puede ser igual a la actual");
                return;
            }

            if (cboatras.Text == "--ESCOGE UNA--")
            {
                MessageBox.Show("No puedes dejar este campo vacio");
                return;
            }

            if (cbosucursal.Text  == "--ESCOGE UNA--")
            {
                MessageBox.Show("No puedes dejar este campo vacio");
                return;
            }


            //FECHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            //=Iif(Day(Fields!fecha.Value)=15,"DEL 1 AL 15 DE "&UCase(MonthName(Month(Fields!fecha.Value)))&" DEL "&Year(Fields!fecha.Value),"DEL 16 AL "& Variables!fecha.Value &" DE "&UCase(MonthName(Month(Fields!fecha.Value)))&" DEL "&Year(Fields!fecha.Value))




            nombre = txtnombre.Text;
            direccion = txtdireccion.Text;
            cedula = mkcedula.Text;
            telefono = mktelefono.Text;
            sucursal = cbosucursal.Text;
            atrasP = cboatras.Text;
            ocupacion = txtocupacion.Text;
            sueldoB = Convert.ToDecimal(txtsueldobruto.Text);
            //horasE = Convert.ToDecimal(txtextras.Text);
            
            
            fechaN = dpnacimiento.Value.Date;
            fechaE = dpentrada.Value.Date;
            fechaS = mkSalida.Text;

            if (chkcomida.Checked)
            {
                comida = true;
            }
            else
            {
                comida = false;
            }

            string fe = fechaS.Replace("-", "");

            if (fe==string.Empty )
            {
                actual = true;

            }
            else
            {
                actual = false;
            }

            CRUDempleados s = new CRUDempleados();
            MessageBox.Show(s.Agregar(nombre ,cedula,direccion,telefono,fechaN,sucursal,atrasP,ocupacion,sueldoB,horasE,seguroP,comida,fechaE,fechaS,actual));

            txtdireccion.Text = string.Empty;
            txtextras.Text = string.Empty;
            //txtmayo.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtocupacion.Text = string.Empty;
            txtseguro.Text = string.Empty;
            txtsueldobruto.Text = string.Empty;
            mkcedula.Text = string.Empty;
            mktelefono.Text = string.Empty;
            cboatras.Text = "--ESCOGE UNA--";
            cbosucursal.Text = "--ESCOGE UNA--";

            cbosucursal.Enabled = false;
            cboatras.Enabled = false;

            chkcomida.Checked = false;
            dpentrada.Value = DateTime.Now.Date;
            dpnacimiento.Value = DateTime.Now.Date;
            mkSalida .Text  = string.Empty;
            btnguardar.Enabled = false;
            btndeshacer.Enabled = false;


            txtdireccion.Enabled = false;
            txtextras.Enabled = false;
            //txtmayo.Enabled = false;
            txtnombre.Enabled = false;
            txtocupacion.Enabled = false;
            txtseguro.Enabled = false;
            txtsueldobruto.Enabled = false;
            mkcedula.Enabled = false;
            mktelefono.Enabled = false;
            cbosucursal.Enabled = false;
            cboatras.Enabled = false;
            chkcomida.Enabled = false; ;
            dpentrada.Enabled = false;
            dpnacimiento.Enabled = false;
            mkSalida.Enabled = false;




        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ltblistado_SelectedIndexChanged(object sender, EventArgs e)
        {

            string nombre = ltblistado.SelectedItem.ToString();
            using (grupohie_nominaEntities db = new grupohie_nominaEntities())
            {
                var resultado = db.empleados.Where(x => x.nombre==nombre).ToList();

                foreach (var i in resultado)
                {
                    txtId.Text = i.id.ToString();
                    txtnombre.Text = i.nombre;
                    txtdireccion.Text = i.direccion;
                    //txtmayo.Text = i.san_mayo.ToString();
                    txtocupacion.Text = i.ocupacion;
                    txtseguro.Text = i.seguro_privado.ToString();
                    txtsueldobruto.Text = i.sueldo_bruto.ToString();
                    mkcedula.Text = i.cedula;
                    mktelefono.Text = i.telefono;
                    chkcomida.Checked = i.comida;
                    cbosucursal.Text = i.sucursal;
                    cboatras.Text = i.parte_atras;
                    dpentrada.Value = i.fecha_entrada;
                    dpnacimiento.Value = i.fecha_nac;
                    mkSalida.Text = i.fecha_salida;
                    txtextras.Text = i.horas_extras.ToString();
                    txtId.Visible = true;
                    lblId.Visible = true;
                    btnAtras.Visible = false;
                    btnCedula.Visible = false;
                    btnComida.Visible = false ;
                    btnDireccion.Visible = false ;
                    btnSueldoB.Visible = false ;
                    btnOcupacion.Visible = false ;
                    btnHE.Visible = false ;
                   // btnSan.Visible = false ;
                    btnSeguro.Visible = false  ;
                    button1.Visible = false ;
                    btnnombre.Visible = false ;
                    btnFechaS.Visible = false ;

                    btneliminar.Enabled = true;
                    btneditar.Enabled = true;

                    txtdireccion.Enabled = false;
                    txtextras.Enabled = false;
                    //txtmayo.Enabled = false;
                    txtnombre.Enabled = false;
                    txtocupacion.Enabled = false;
                    txtseguro.Enabled = false;
                    txtsueldobruto.Enabled = false;
                    mkcedula.Enabled = false;
                    mktelefono.Enabled = false;
                    cbosucursal.Enabled = false;
                    cboatras.Enabled = false;
                    chkcomida.Enabled = false; ;
                    dpentrada.Enabled = false;
                    dpnacimiento.Enabled = false;
                    mkSalida.Enabled = false;
                    ltblistado.Items.Clear();
                }
                

            }

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            string _nombre = txtbuscar.Text;
            ltblistado.Items.Clear();
            txtId.Visible = false ;
            lblId.Visible = false ;

            if (_nombre != string.Empty)
            {
                using (grupohie_nominaEntities db = new grupohie_nominaEntities())
                {
                    var resultado = db.empleados.Where(x => x.nombre.Contains(_nombre)).ToList();


                    foreach (var p in resultado)
                    {

                        ltblistado.Items.Add(p.nombre);
                    }

                }

            }
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            btnCedula.Visible = true;
            btnComida.Visible = true;
            btnDireccion.Visible = true;
            btnSueldoB.Visible = true;
            btnOcupacion.Visible = true;
            btnHE.Visible = true;
            //btnSan.Visible = true;
            btnSeguro.Visible = true;
            button1.Visible = true;
            btnAtras.Visible = true;
            btnnombre.Visible = true;
            btnFechaS.Visible = true;
            btnGuardarCambios.Visible = true;
            btnnuevo.Enabled = false;
            btndeshacer.Enabled = true;
            timer1.Start();
            timer1.Enabled = true;
            //timer1.
           

        }

        private void btnnombre_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
        }

        private void btnDireccion_Click(object sender, EventArgs e)
        {
            txtdireccion.Enabled = true;

        }

        private void btnCedula_Click(object sender, EventArgs e)
        {
            mktelefono.Enabled = true;
        }

        private void btnOcupacion_Click(object sender, EventArgs e)
        {
            txtocupacion.Enabled = true;
        }

        private void btnSueldoB_Click(object sender, EventArgs e)
        {
            txtsueldobruto.Enabled = true;
        }

        private void btnHE_Click(object sender, EventArgs e)
        {
            txtextras.Enabled = true;
        }

        private void btnSeguro_Click(object sender, EventArgs e)
        {
            txtseguro.Enabled = true;
        }

       

        private void btnComida_Click(object sender, EventArgs e)
        {
            chkcomida.Enabled = true;
        }

        private void btnFechaE_Click(object sender, EventArgs e)
        {
            dpentrada.Enabled = true;
        }

        private void btnFechaS_Click(object sender, EventArgs e)
        {
            mkSalida.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbosucursal.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            numero += 1;
            if (numero % 2 == 0)
            {
                btnGuardarCambios.BackColor = Color.YellowGreen;
                btnGuardarCambios.ForeColor = Color.White;
            }
            else
            {
                btnGuardarCambios.BackColor = Color.LightPink;
                btnGuardarCambios.ForeColor = Color.Black;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nombre, direccion, cedula, telefono, sucursal,atrasP, fechaS, ocupacion;
            decimal sueldoB, horasE, seguroP;
            DateTime fechaE,  fechaN;
            bool comida, actual;
            DateTime fecha = DateTime.Now.Date;


            nombre = txtnombre.Text;
            direccion = txtdireccion.Text;
            cedula = mkcedula.Text;
            telefono = mktelefono.Text;
            sucursal = cbosucursal.Text;
            atrasP = cboatras.Text;
            ocupacion = txtocupacion.Text;
            sueldoB = Convert.ToDecimal(txtsueldobruto.Text);



            fechaN = dpnacimiento.Value.Date;
            fechaE = dpentrada.Value.Date;
            fechaS = mkSalida.Text ;

            if (chkcomida.Checked)
            {
                comida = true;
            }
            else
            {
                comida = false;
            }
            string fe = fechaS.Replace("-", "");
            if (fe==string.Empty )
            {
                actual = true;

            }
            else
            {
                actual = false;
            }

            horasE = Convert.ToDecimal(txtextras.Text);
            seguroP = Convert.ToDecimal(txtseguro.Text );
          //sanM  = Convert.ToDecimal(txtmayo.Text);


            CRUDempleados s = new CRUDempleados();
            MessageBox.Show(s.Modificar( id,nombre, direccion, sucursal,atrasP , telefono, ocupacion, sueldoB, horasE, seguroP, comida, fechaS, actual));


            txtId.Visible = false;
            lblId.Visible = false ;

            btnCedula.Visible = false;
            btnComida.Visible = false;
            btnDireccion.Visible = false;
            btnSueldoB.Visible = false;
            btnOcupacion.Visible = false;
            btnHE.Visible = false;
            //btnSan.Visible = false;
            btnSeguro.Visible = false;
            button1.Visible = false;
            btnnombre.Visible = false;
            btnFechaS.Visible = false;
            btnAtras.Visible = false;


            txtdireccion.Enabled = false;
            txtextras.Enabled = false;
           // txtmayo.Enabled = false;
            txtnombre.Enabled = false;
            txtocupacion.Enabled = false;
            txtseguro.Enabled = false;
            txtsueldobruto.Enabled = false;
            mkcedula.Enabled = false;
            mktelefono.Enabled = false;
            cbosucursal.Enabled = false;
            chkcomida.Enabled = false; ;
            dpentrada.Enabled = false;
            dpnacimiento.Enabled = false;
            mkSalida.Enabled = false;

            //POR AQUIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
            txtdireccion.Text = string.Empty;
            txtextras.Text = string.Empty;
            //txtmayo.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtocupacion.Text = string.Empty;
            txtseguro.Text = string.Empty;
            txtsueldobruto.Text = string.Empty;
            mkcedula.Text = string.Empty;
            mktelefono.Text = string.Empty;
            cboatras.Text = "--ESCOGE UNA--";
            cbosucursal.Text = "--ESCOGE UNA--";

            cbosucursal.Enabled = false;
            cboatras.Enabled = false;

            chkcomida.Checked = false;
            dpentrada.Value = DateTime.Now.Date;
            dpnacimiento.Value = DateTime.Now.Date;
            mkSalida.Text = string.Empty;
            btnguardar.Enabled = false;
            btndeshacer.Enabled = false;

            btnGuardarCambios.Visible = false;
            timer1.Stop();


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            CRUDempleados s = new CRUDempleados();
            
            
            MessageBox.Show(s.Eliminar(id));

            txtId.Visible = false;
            lblId.Visible = false;

            btnCedula.Visible = false;
            btnComida.Visible = false;
            btnDireccion.Visible = false;
            btnSueldoB.Visible = false;
            btnOcupacion.Visible = false;
            btnHE.Visible = false;
           // btnSan.Visible = false;
            btnSeguro.Visible = false;
            button1.Visible = false;
            btnnombre.Visible = false;
            btnFechaS.Visible = false;
            btnAtras.Visible = false;


            txtdireccion.Enabled = false;
            txtextras.Enabled = false;
            //txtmayo.Enabled = false;
            txtnombre.Enabled = false;
            txtocupacion.Enabled = false;
            txtseguro.Enabled = false;
            txtsueldobruto.Enabled = false;
            mkcedula.Enabled = false;
            mktelefono.Enabled = false;
            cbosucursal.Enabled = false;
            cboatras.Enabled = false;
            chkcomida.Enabled = false; ;
            dpentrada.Enabled = false;
            dpnacimiento.Enabled = false;
            mkSalida.Enabled = false;


            txtdireccion.Text = string.Empty;
            txtextras.Text = string.Empty;
            //txtmayo.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtocupacion.Text = string.Empty;
            txtseguro.Text = string.Empty;
            txtsueldobruto.Text = string.Empty;
            mkcedula.Text = string.Empty;
            mktelefono.Text = string.Empty;

            cboatras.Text = "--ESCOGE UNA--";
            cbosucursal.Text = "--ESCOGE UNA--";

            cbosucursal.Enabled = false;

            chkcomida.Checked = false;
            dpentrada.Value = DateTime.Now.Date;
            dpnacimiento.Value = DateTime.Now.Date;
            mkSalida.Text = string.Empty;
            btnguardar.Enabled = false;
            btndeshacer.Enabled = false;
        }

        private void mkcedula_Leave(object sender, EventArgs e)
        {
            CRUDempleados s = new CRUDempleados();

            string cedula = mkcedula.Text;
            string ver = cedula.Replace("-", "");
            if (ver.Length >=11)
            {
                if (s.existe(cedula))
                {
                    MessageBox.Show("ESTA CEDULA YA ESTA REGISTRADA");
                    mkcedula.Text = string.Empty;
                    mkcedula.Focus();
                    return;
                }
            }

            if (ver == "")
            {
                MessageBox.Show("ESTE CAMPO NO PUEDE ESTAR VACIO");
                mkcedula.Text = string.Empty;
                mkcedula.Focus();
                return;
            }
            
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            cboatras.Enabled = true;
        }

        private void mkcedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
