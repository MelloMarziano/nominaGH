using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaGH.Models;

namespace NominaGH.Controls
{
    class CRUDempleados
    {
        public string Agregar(string nombre,string cedula,string direccion,string telefono,DateTime fechaN,string sucursal,string atrasP,string ocupacion,decimal sueldoB,decimal horasE,decimal seguroP,bool comida,DateTime fechaE,string fechaS,bool actual )
        {


            using (grupohie_nominaEntities db = new grupohie_nominaEntities())
            {
                empleados n = new empleados();
                n.nombre = nombre;
                n.cedula = cedula;
                n.direccion = direccion;
                n.telefono = telefono;
                n.fecha_nac = fechaN;
                n.sucursal = sucursal;
                n.parte_atras = atrasP;
                n.ocupacion = ocupacion;
                n.sueldo_bruto = sueldoB;
                n.horas_extras = horasE;
                n.seguro_privado = seguroP;
                n.san_mayo = 0;
                n.comida = comida;
                n.fecha_entrada = fechaE;
                n.fecha_salida = fechaS;
                n.actual = actual;

                db.empleados.Add(n);
                db.SaveChanges();
            }




            return "Empleado Agregado Correctamente";
        }


        public string Modificar(int _id,string nombre,  string direccion,string sucursal,string atrasP, string telefono,string ocupacion, decimal sueldoB, decimal horasE, decimal seguroP, bool comida,  string fechaS, bool actual)
        {
            using (grupohie_nominaEntities db = new grupohie_nominaEntities())
            {
                var resultado = db.empleados.Where(x => x.id == _id).FirstOrDefault ();
                resultado.nombre = nombre;
                resultado.direccion = direccion;
                resultado.telefono = telefono;
                resultado.ocupacion = ocupacion;
                resultado.sueldo_bruto = sueldoB;
                resultado.horas_extras = horasE;
                resultado.seguro_privado = seguroP;
                //resultado.san_mayo = san;
                resultado.comida = comida;
                resultado.fecha_salida = fechaS;
                resultado.actual = actual;
                resultado.sucursal = sucursal;
                resultado.parte_atras = atrasP;
                db.SaveChanges();


            }
            return "Empleado modificado correctamente";
        }

        public string Eliminar(int _id)
        {

            using (grupohie_nominaEntities db = new grupohie_nominaEntities())
            {
                var resultado = db.empleados.Where(x => x.id == _id).FirstOrDefault();
                db.empleados.Remove(resultado);
                db.SaveChanges();
            }
            return "Empleado Eliminado correctamente";
        }



        //EXISTE*********************************************************************************************************************************
        public bool existe(string _cedula)
        {
            int saber;

            using (grupohie_nominaEntities  db = new grupohie_nominaEntities ())
            {
                //var resultado = db.usuarios.OrderByDescending(i => i.id).FirstOrDefault().id ;
                saber = db.empleados.Where(i => i.cedula == _cedula).Count();
            }
            if (saber <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            //return saber2;
        }

    }
}
