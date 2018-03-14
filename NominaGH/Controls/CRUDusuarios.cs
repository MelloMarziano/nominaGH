using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaGH.Models;

namespace NominaGH.Controls
{
    class CRUDusuarios
    {

        public bool login(string _nombre,string _clave)
        {
            int saber;
            using (grupohie_nominaEntities  db = new grupohie_nominaEntities())
            {
                saber = db.usuarios.Where(i => i.usuario  == _nombre.ToUpper() && i.clave == _clave.ToUpper()).Count();
            }
            if (saber <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
