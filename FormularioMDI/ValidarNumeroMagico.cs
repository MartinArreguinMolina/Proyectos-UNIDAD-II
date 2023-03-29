using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioMDI
{
    internal class ValidarNumeroMagico
    {
        public bool validarNumeros(char tecla)
        {
            if (char.IsDigit(tecla))
            {
                return true;
            }
            else if (tecla == '.')
            {
                return false;
            }
            else if (tecla == (char)Keys.Back)
            {
                return true;
            }
            else if (tecla == '-')
            {
                return false;
            }


            return false;
        }


        public bool vacio(string cadenaUno)
        {
            if (cadenaUno.Equals(""))
            {
                return false;
            }
            else if (cadenaUno.Equals("-"))
            {
                return false;
            }
            else if (cadenaUno.Equals("."))
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
