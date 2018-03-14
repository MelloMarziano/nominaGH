using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaGH.Models;

namespace NominaGH.Controls
{
    class editarNomina
    {
        public string Modificar(int _id,DateTime fecha,decimal mayo,decimal prestamo,decimal almacen,decimal otros)
        {
            using (grupohie_nominaEntities db = new grupohie_nominaEntities())
            {
                var resultado = db.resultados.Where(x => x.id == _id && x.fecha == fecha).FirstOrDefault();
                decimal total= mayo+prestamo + almacen + otros;
                decimal totalD = resultado.total_descuento2;
                decimal toF= totalD + total;

                
                resultado.total_descuento2 = toF;

                decimal neto = resultado.neto_apagar2;

                resultado.neto_apagar3 = neto - toF - resultado.comida;

                resultado.san_mayo = mayo;
                resultado.prestamo = prestamo;
                resultado.desayuno = almacen;
                resultado.otros = otros;


                db.SaveChanges();
            }
            return "Nomina Modificada Correctamente";
        }

        public bool existe(DateTime _fecha)
        {
            int saber;

            using (grupohie_nominaEntities db = new grupohie_nominaEntities())
            {
                //var resultado = db.usuarios.OrderByDescending(i => i.id).FirstOrDefault().id ;
                saber = db.resultados.Where(i => i.fecha == _fecha).Count();
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
