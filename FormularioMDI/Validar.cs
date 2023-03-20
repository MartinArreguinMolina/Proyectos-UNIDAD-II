using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioMDI
{
    internal class Validar
    {
        public bool validarNumeros(char tecla, string cadena)
        {
            if (char.IsDigit(tecla))
            {
                return true;
            }
            else if (tecla == '.')
            {
                if (cadena.Contains("."))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (tecla == (char)Keys.Back)
            {
                return true;
            }
            else if (tecla == '-')
            {
                if (cadena.Equals(""))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            return false;
        }

        public bool vacio(string cadenaUno)
        {
            if (cadenaUno.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
