using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Class
{
    public class VerificaDeposito
    {
        public static bool verificaDeposito(string valor, string nome, string numeroCart, string validade, string CVV)
        {
            DateTime valid;
            try
            {
                valid = Convert.ToDateTime(validade);
            }
            catch (Exception)
            {
                return false;
            }

            if (valor == "0" || valor == "" || nome == "" || numeroCart.Length < 15 || CVV.Length < 2 || valid.Date < DateTime.Today)
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
