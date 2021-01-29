using SistemaBancario.Class;
using SistemaBancario.Entity;
using SistemaBancario.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario
{
    public partial class Login : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        List<Contas> contas = new List<Contas>();

        public Login()
        {
            InitializeComponent();

            contas.Add(new Contas() { ID = 0, Banco = "154", Agencia = "1654", NumeroConta = "549879", TipoConta = "Conta Poupança", Saldo = 0 });
            methodUsuario();
        }

        void methodUsuario()
        {
            usuarios.Add(new Usuario()
            {
                Username = "Thy",
                Password = "123",
                Cpf = "123.123.123-88",
                Email = "thyago@hotmail.com",
                Contas = contas,
                ValorTotal = 0
            });
        }

        //----------------------------------start-Mover formulario & fechar form----------------------------
        Point DragCursor;
        Point DragForm;
        bool Dragging;
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a aplicação?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        //--------------------------------end-Mover formulario & fechar form--------------------------------
        //
        //------------------------------start-Adcionar ou logar---------------------------------------------
        
        //Methods
        private void ControlLogar()
        {
            pnlEntrar.Visible = true;
            pnlCadastro.Visible = false;
        }        
        private void ControlAdicionar()
        {
            pnlEntrar.Visible = false;
            pnlCadastro.Visible = true;
        }

        //events
        private void xuiBntVoltar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Atenção ao clicar no botão voltar todos os campos seram limpos automaticamente!" + "\n" + "Deseja voltar mesmo assim?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ControlLogar();
                LimparCampos();
            }
        }

        private void xuiBntAdd_Click(object sender, EventArgs e)
        {
            ControlAdicionar();
            LimparCamposAdd();
        }
        //-------------------------------end-Adcionar ou logar----------------------------------------------
        //
        //-------------------------------start-Area Logar---------------------------------------------------
        
        //methods
        private void LimparCampos()
        {
            mskUser.Clear();
            mskPass.Clear();
        }

        //events
        private void btnViewPass_Click(object sender, EventArgs e)
        {
            btnViewPass.Visible = false;
            btnConfidentPass.Visible = true;
            mskPass.PasswordChar = Convert.ToChar("\0");
        }

        private void btnConfidentPass_Click(object sender, EventArgs e)
        {
            btnViewPass.Visible = true;
            btnConfidentPass.Visible = false;
            mskPass.PasswordChar = Convert.ToChar("*");
        }

        private void xuiBtnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Usuario usuarios in usuarios)
                {
                    if (usuarios.Username == mskUser.Text && usuarios.Password == mskPass.Text)
                    {
                        Iniciar();
                    }
                }
                MessageBox.Show("Usuario ou senha incorretos", "Erro!");
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se os campos acima foram preenchidos corretamente", "Atenção");
            }
        }
        //-------------------------------end-Area Logar----------------------------------------------------
        //
        //-------------------------------start-Area Adicionar----------------------------------------------

        //Class
        private bool VerificacaoDados()
        {
            if(mskAdUser.Text == "" || mskAdPass.Text == "")
            {
                MessageBox.Show("Verifique se preencheu os campos de Usuario e Senha", "Ateção");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VerificaCpf()
        {
            if (ValidaCPF.IsCpf(mskAdCpf.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("CPF inválido!", "Atenção!");
                mskAdCpf.Clear();
                return false;
            }
        }

        private bool VerificaEmail()
        {
            if (ValidaEmail.isEmail(mskAdEmail.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Email inválido!", "Atenção!");
                mskAdEmail.Clear();
                return false;
            }
        }

        private bool VerificaConta()
        {
            if (contas.Count == 0)
            {
                MessageBox.Show("É nescessario adicionar ao menos uma conta!", "Atenção!");
                return false;
            }
            else
            {
                return true;
            }
        }

        //methods
        private void LimparCamposAdd()
        {
            mskAdUser.Clear();
            mskAdPass.Clear();
            mskAdEmail.Clear();
            mskAdCpf.Clear();
            contas = new List<Contas>();
            picBVerificado.Visible = false;
        }

        public void AdicionarConta(List<Contas> conta)
        {
            contas = conta;
            picBVerificado.Visible = true;
        }

        //events
        private void btnAddViewPass_Click(object sender, EventArgs e)
        {
            btnAddViewPass.Visible = false;
            btnAddConfidentPass.Visible = true;
            mskAdPass.PasswordChar = Convert.ToChar("\0");
        }

        private void btnAddConfidentPass_Click(object sender, EventArgs e)
        {
            btnAddViewPass.Visible = true;
            btnAddConfidentPass.Visible = false;
            mskAdPass.PasswordChar = Convert.ToChar("*");
        }

        SistemBank sis;
        public bool addConta = false;
        private void xuiBtnConta_Click(object sender, EventArgs e)
        {
            if (addConta == false)
            {
                Conta screenConta = new Conta(this, sis);
                screenConta.Show();
                addConta = true;
            } 
            else
                return;
        }

        private void xuiBtnFinalizar_Click(object sender, EventArgs e)
        {
            if (VerificacaoDados() && VerificaCpf() && VerificaEmail() && VerificaConta())
            {
                Usuario.AddUsers(usuarios, mskAdUser.Text, mskAdPass.Text, mskAdEmail.Text, mskAdCpf.Text, contas);
                LimparCamposAdd();
                ControlLogar();
                MessageBox.Show("Cadastro feito com êxito!", "Aprovado");
            }
        }
        //-------------------------------end-Area Adicionar------------------------------------------------
        //
        //-------------------------------start-Inicialização do sistema------------------------------------
        Thread SisBank;

        private void Iniciar()
        {
            this.Close();
            SisBank = new Thread(Aplicativo);
            SisBank.SetApartmentState(ApartmentState.STA);
            SisBank.Start();
        }

        private void Aplicativo()
        {
            Application.Run(new SistemBank(this, usuarios));
        }
        //------------------------------end-Inicialização do sistema---------------------------------------
    }
}
