using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaGH.Models;

namespace NominaGH.Controls
{
    class reporteCompleto
    {
        //EXISTE*********************************************************************************************************************************
        public bool existe(string _sucursal,DateTime  _fecha)
        {
            int saber;

            using (grupohie_nominaEntities db = new grupohie_nominaEntities())
            {
                //var resultado = db.usuarios.OrderByDescending(i => i.id).FirstOrDefault().id ;
                saber = db.resultados.Where(i => i.sucursal  == _sucursal && i.fecha == _fecha).Count();
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
