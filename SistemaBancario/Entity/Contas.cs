using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entity
{
    public class Contas
    {
        public int ID { get; set; }
        public string TipoConta { get; set; }
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public string Banco { get; set; }
        public double Saldo { get; set; }

        public static void AddContas(List<Contas> conta, string TipConta, string Agenc, string NumCont, string Bank)
        {
            conta.Add(new Contas()
            {
                ID = getId(conta),
                TipoConta = TipConta,
                Agencia = Agenc,
                NumeroConta = NumCont,
                Banco = Bank,
                Saldo = 0
            }) ;
        }

        public static int getId(List<Contas> conta)
        {
            if(conta.Count() == 0)
            {
                return 0;
            }

            int i = 0;
            foreach (Contas contas in conta)
            {
                if (contas.ID == i)
                {
                    i++;
                }
                else
                {
                    return i;
                }
            }
            return i++;
        }

        public override string ToString()
        {
            return Banco + "/" + Agencia +  "/" + NumeroConta;
        }
    }
}
