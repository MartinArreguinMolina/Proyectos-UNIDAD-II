using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioMDI
{
    internal class ValidarContraseña
    {

        string contraseña = "TI21110045";
        public bool valirdarContraseña(string cadena)
        {
            if (cadena.Equals(contraseña)) return true;

            return false;
        }
    }
}
