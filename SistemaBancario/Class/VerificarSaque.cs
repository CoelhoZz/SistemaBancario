using SistemaBancario.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Class
{
    public class VerificarSaque
    {
        public static bool verificaDeposito(string valor,string tipo, string formaDeTransf, string assinaturaDigital)
        {
            if (valor == "0" || valor == "" || (formaDeTransf.Length < 7 && tipo == "TELEFONE") || ValidaCPF.IsCpf(formaDeTransf) == false || assinaturaDigital == "" || (Convert.ToInt32(assinaturaDigital) * 2) == 0)
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
