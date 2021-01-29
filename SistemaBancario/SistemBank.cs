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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario
{
    public partial class SistemBank : Form
    {
        private Login login;
        private List<Usuario> usuarios;

        

        public SistemBank(Login login, List<Usuario> usuarios)
        {
            InitializeComponent();
            this.login = login;
            this.usuarios = usuarios;


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
        //-------------------------------start-Inicilização------------------------------------

        //excessões
        private void cbmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaldoEspecificoDep();
        }

        private void cbmSacar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaldoEspecificoSaq();
        }

        //methods
        private void SaldoEspecificoDep()
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Cpf == mskCpf.Text)
                {
                    foreach (Contas contas in usuario.Contas)
                    {
                        if (cbmBox.Text == contas.ToString())
                        {
                            xuiCardConta.Text1 = "Saldo: " + contas.Saldo.ToString("C2");
                            xuiCardConta.Text2 = contas.ToString();
                            xuiCardConta.Text3 = contas.TipoConta;
                            return;
                        }
                    }
                }
            }

        }

        private void SaldoEspecificoSaq()
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Cpf == mskCpf.Text)
                {
                    foreach (Contas contas in usuario.Contas)
                    {
                        if (cbmSacar.Text == contas.ToString())
                        {
                            mskSaqSaldo.Mask = null;
                            mskSaqSaldo.Text = contas.Saldo.ToString("C2"); 
                            return;
                        }
                    }
                }
            }

        }

        private void MinhaConta()
        {
            foreach(Usuario usuario in usuarios)
            {
                lblMessageminicial.Text = "Seja bem-vindo!!"+ "\n" + usuario.Username + "!!";
                mskUsuario.Text = usuario.Username;
                mskSenha.Text = usuario.Password;
                mskEmail.Text = usuario.Email;
                mskCpf.Text = usuario.Cpf;
            }
        }

        private void AtualizarConta()
        {
            foreach (Usuario usuario in usuarios)
            {
                if(mskCpf.Text == usuario.Cpf)
                {
                    cbmBox.DataSource = null;
                    cbmBox.DataSource = usuario.Contas;

                    lblSaldoTotal.Text = usuario.ValorTotal.ToString("C2");

                    cbmSacar.DataSource = null;
                    cbmSacar.DataSource = usuario.Contas;

                    cbmContaDeposito.DataSource = null;
                    cbmContaDeposito.DataSource = usuario.Contas;

                    cbmMinhasContas.DataSource = null;
                    cbmMinhasContas.DataSource = usuario.Contas;
                }
            }
        }

        //events
        private void SistemBank_Load(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToShortTimeString();
            ViewInicial();
            MinhaConta();
            AtualizarConta();
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToShortTimeString();
        }
        //-------------------------------end-Inicialização--------------------------------------------------------
        //
        //-------------------------------start-Visualizar Telas---------------------------------------------------

        //methods
        private void ViewSaldo()
        {
            pnlInicial.Visible = false;
            pnlSaldo.Visible = true;
            pnlSacar.Visible = false;
            pnlMinhaConta.Visible = false;
            pnlDeposito.Visible = false;
            desabilitarEdição();
            MinhaConta();
        }        
        private void ViewSacar()
        {
            pnlInicial.Visible = false;
            pnlSaldo.Visible = false;
            pnlSacar.Visible = true;
            pnlMinhaConta.Visible = false;
            pnlDeposito.Visible = false;
            desabilitarEdição();
            MinhaConta();
        }        
        private void ViewMinhaConta()
        {
            pnlInicial.Visible = false;
            pnlSaldo.Visible = false;
            pnlSacar.Visible = false;
            pnlMinhaConta.Visible = true;
            pnlDeposito.Visible = false;
            desabilitarEdição();
            MinhaConta();
        }        
        private void ViewDepositar()
        {
            pnlInicial.Visible = false;
            pnlSaldo.Visible = false;
            pnlSacar.Visible = false;
            pnlMinhaConta.Visible = false;
            pnlDeposito.Visible = true;
            desabilitarEdição();
            MinhaConta();
        }
        private void ViewInicial()
        {
            pnlInicial.Visible = true;
            pnlSaldo.Visible = false;
            pnlSacar.Visible = false;
            pnlMinhaConta.Visible = false;
            pnlDeposito.Visible = false;
            desabilitarEdição();
            MinhaConta();
        }

        //events
        private void btnSaldo_Click(object sender, EventArgs e)
        {
            ViewSaldo();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            ViewSacar();
        }

        private void btnMinhaconta_Click(object sender, EventArgs e)
        {
            ViewMinhaConta();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            ViewDepositar();
        }

        private void btnInicial_Click(object sender, EventArgs e)
        {
            ViewInicial();
        }
        //-------------------------------end-Visualizar Telas----------------------------------------------------
        //
        //-------------------------------start-Area Edição de Conta----------------------------------------------

        //methods
        private void habilitarEdição()
        {
            mskUsuario.Enabled = true;
            mskSenha.Enabled = true;
            mskEmail.Enabled = true;
            cbmMinhasContas.Enabled = true;

            btnSalvarConta.Enabled = true;
            btnEditarConta.Enabled = false;
            xuiBtnAdicionar.Enabled = true;
            xuiBtnRemoverConta.Enabled = true;
        }
        private void desabilitarEdição()
        {
            mskUsuario.Enabled = false;
            mskSenha.Enabled = false;
            mskEmail.Enabled = false;
            cbmMinhasContas.Enabled = false;

            btnSalvarConta.Enabled = false;
            btnEditarConta.Enabled = true;
            xuiBtnAdicionar.Enabled = false;
            xuiBtnRemoverConta.Enabled = false;
        }

        public void AdicionarConta(List<Contas> contas)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Cpf == mskCpf.Text)
                {
                    usuario.Contas.AddRange(contas);
                }
            }
            AtualizarConta();
        }

        //events
        private void btnAddConfidentPass_Click(object sender, EventArgs e)
        {
            btnAddViewPass.Visible = true;
            btnAddConfidentPass.Visible = false;
            mskSenha.PasswordChar = Convert.ToChar("*");
        }

        private void btnAddViewPass_Click(object sender, EventArgs e)
        {
            btnAddViewPass.Visible = false;
            btnAddConfidentPass.Visible = true;
            mskSenha.PasswordChar = Convert.ToChar("\0");
        }

        Login log;
        public bool addConta;
        private void xuiBtnAdicionar_Click(object sender, EventArgs e)
        {
            if (addConta == false)
            {
                Conta screenConta = new Conta(log, this);
                screenConta.Show();
                addConta = true;
            }
            else
                return;
        }

        private void xuiBtnRemoverConta_Click(object sender, EventArgs e)
        {
            int res = 0;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Cpf == mskCpf.Text)
                {
                    foreach (Contas contas in usuario.Contas)
                    {
                        if (contas.ToString() == cbmMinhasContas.Text && contas.Saldo == 0)
                        {
                            usuario.Contas.RemoveAt(res = cbmMinhasContas.FindStringExact(cbmMinhasContas.Text));
                            AtualizarConta();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não é possivel excluir um conta com saldo!", "Atenção!");
                            return;
                        }
                    }  
                }
            }
        }

        private void btnEditarConta_Click(object sender, EventArgs e)
        {
            habilitarEdição();
        }

        private void btnSalvarConta_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja salvar as alterações feitas?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach(Usuario usuario in usuarios)
                {
                    if(usuario.Cpf == mskCpf.Text)
                    {
                        usuario.Username = mskUsuario.Text;
                        usuario.Password = mskSenha.Text;
                        usuario.Email = mskEmail.Text;
                        desabilitarEdição();
                        return;
                    }
                }
            }
            else
            {
                MinhaConta();
                desabilitarEdição();
            }
            
        }
        //-------------------------------end-Area Edição de conta---------------------------------------------------------
        //
        //-------------------------------start-Area Deposito, Saque e Saldo-----------------------------------------------

        //method
        private void limparCamposDeposito()
        {
            mskDepValor.Clear();
            mskDepNome.Clear();
            txbDepBanco.Clear();
            mskDepValidade.Clear();
            txbDepCvv.Clear();
        }

        //events
        private void KeyPress_SoNumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void KeyPress_SoLetra(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnFinalizarDeposito_Click(object sender, EventArgs e)
        {
            if(VerificaDeposito.verificaDeposito(mskDepValor.Text, mskDepNome.Text, txbDepBanco.Text, mskDepValidade.Text, txbDepCvv.Text))
            {
                foreach(Usuario usuario in usuarios)
                {
                    if(usuario.Cpf == mskCpf.Text)
                    {
                        usuario.ValorTotal = usuario.ValorTotal + Convert.ToDouble(mskDepValor.Text);
                        foreach(Contas contas in usuario.Contas)
                        {
                            if(cbmContaDeposito.Text == contas.ToString())
                            {
                                contas.Saldo = contas.Saldo + Convert.ToDouble(mskDepValor.Text);
                                MessageBox.Show("Deposito concluido com sucessor!", "Atenção");
                                AtualizarConta();
                                SaldoEspecificoDep();
                                limparCamposDeposito();
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifique se preencheu todos os campos corretamente!", "Atenção");
            }
        }

        private void cbmFormasTransf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbmFormasTransf.Text.StartsWith("CPF"))
            {
                mskSaqTransf.Visible = true;
                mskSaqTransf.Mask = null;
                mskSaqTransf.Mask = "000,000,000-00";
            }
            else
            {
                mskSaqTransf.Visible = true;
                mskSaqTransf.Mask = null;
                mskSaqTransf.Mask = "00000-9999";
            }
        }

        private void btnFinalizarSaque_Click(object sender, EventArgs e)
        {
            if (VerificarSaque.verificaDeposito(mskSaqSaldo.Text, cbmFormasTransf.Text, mskSaqTransf.Text, mskSaqAssin.Text))
            {
                foreach (Usuario usuario in usuarios)
                {
                    if (usuario.Cpf == mskCpf.Text)
                    {
                        foreach (Contas contas in usuario.Contas)
                        {
                            if (cbmContaDeposito.Text == contas.ToString())
                            {
                                if(0 <= Convert.ToDouble(mskSaqSaldo.Text.Replace("R$", "")) && contas.Saldo >= Convert.ToDouble(mskSaqSaldo.Text.Replace("R$", "")))
                                {
                                    usuario.ValorTotal = usuario.ValorTotal - Convert.ToDouble(mskSaqSaldo.Text.Replace("R$", ""));
                                    contas.Saldo = contas.Saldo - Convert.ToDouble(mskSaqSaldo.Text.Replace("R$", ""));
                                    MessageBox.Show("Saque concluido com sucessor!", "Atenção");
                                    AtualizarConta();
                                    mskSaqAssin.Clear();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Saldo indisponivel!", "Atenção");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifique se preencheu todos os campos corretamente!", "Atenção");
            }
        }
        //-------------------------------end-Area Deposito, Saque e Saldo--------------------------------------------------
    }
}
