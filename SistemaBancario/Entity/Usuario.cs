using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entity
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public List<Contas> Contas { get; set; }
        public double ValorTotal { get; set; }

        public static void AddUsers(List<Usuario> usuarios, string User, string Pass, string Email, string Cpf, List<Contas> contas)
        {
            usuarios.Add(new Usuario()
            {
                Username = User,
                Password = Pass,
                Email = Email,
                Cpf = Cpf,
                Contas = contas,
                ValorTotal = 0
            });
        }

        public override string ToString()
        {
            return Contas.ToString();
        }
    }
}
