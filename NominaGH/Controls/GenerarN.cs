using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaGH.Models;

namespace NominaGH.Controls
{
    class GenerarN
    {

        //EXISTE*********************************************************************************************************************************
        public bool existe(DateTime _fecha)
        {
            int saber;

            using (grupohie_nominaEntities db = new grupohie_nominaEntities())
            {
                //var resultado = db.usuarios.OrderByDescending(i => i.id).FirstOrDefault().id ;
                saber = db.resultados .Where(i => i.fecha  == _fecha).Count();
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

        public string Generar(DateTime _fecha)
        {
            using (grupohie_nominaEntities db = new grupohie_nominaEntities())
            {
                var resul = db.empleados;

                resultados n = new resultados();
                decimal comida;

                foreach (var i in resul)
                {
                    n.nombre = i.nombre;
                    n.cedula = i.cedula;
                    n.ocupacion = i.ocupacion;
                    n.sucursal = i.sucursal;
                    n.sucursal2 = i.parte_atras;
                    n.sueldo_bruto = i.sueldo_bruto/2;
                    n.horas_extras = i.horas_extras/2;
                    n.seguro = i.seguro_privado;
                    n.san_mayo = 0;
                    if (i.comida)
                    {
                        comida = 440;
                    }
                    else
                    {
                        comida  = 0;
                    }
                    n.comida=comida;
                    n.neto_apagar = (i.sueldo_bruto / 2) + (i.horas_extras/2);
                    n.afp = ((i.sueldo_bruto / 2) + (i.horas_extras / 2)) * Convert.ToDecimal(0.0287);
                    n.sfs = ((i.sueldo_bruto / 2) + (i.horas_extras / 2)) * Convert.ToDecimal(0.0304);
                    n.isr = 0;
                    decimal totalD = (((i.sueldo_bruto / 2) + (i.horas_extras / 2)) * Convert.ToDecimal(0.0287)) + (((i.sueldo_bruto / 2) + (i.horas_extras / 2)) * Convert.ToDecimal(0.0304)) + i.seguro_privado;
                    n.total_decuento = totalD;
                    decimal neto2=((i.sueldo_bruto / 2) + (i.horas_extras/2)) - totalD;
                    n.neto_apagar2 = neto2 ;
                    n.prestamo = 0;
                    n.desayuno = 0;
                    n.otros = 0;
                    n.total_descuento2 = 0;// i.san_mayo;
                    n.neto_apagar3 = neto2 - comida ;
                    n.fecha = _fecha;
                    using (grupohie_nominaEntities db2 = new grupohie_nominaEntities())
                    {
                        db2.resultados.Add(n);
                        db2.SaveChanges();
                    }
                    
                }
                

            }

            return "Nomina Generada Correctamente";
        }
    }
}
