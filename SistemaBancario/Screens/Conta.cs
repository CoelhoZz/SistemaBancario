using SistemaBancario.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario.Screens
{
    public partial class Conta : Form
    {
        Login Login;
        SistemBank SistemBank;

        List<Contas> contas = new List<Contas>();

        public Conta(Login login, SistemBank sistemBank)
        {
            InitializeComponent();
            this.Login = login;
            this.SistemBank = sistemBank;
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
        //--------------------------------end-Mover formulario & fechar form--------------------------------

        //----------------------------------start-Adicionar conta ou Cancelar----------------------------

        //Class
        private bool Verrificacao(string Bank, string TipConta, string NumConta, string Agenc)
        {
            if (Bank == "" || Bank == "000" || TipConta == "" || NumConta == "" || NumConta == "0000000000" || Agenc == "" || Agenc == "0000")
            {
                return false;
            }
            else
            {
                Contas.AddContas(contas, TipConta, Agenc, NumConta, Bank);
                return true;
            }
        }

        //events
        private void KeyPress_CodigoBar(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void xuiBtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Login.addConta = false;
                }
                catch
                {
                    SistemBank.addConta = false;
                }
                this.Close();
            }

        }

        private void xuiSbtnAdicionar_Click(object sender, EventArgs e)
        {
            if (Verrificacao(txbBanco.Text, cbmBox.Text, txbNumConta.Text, txbAgencia.Text) == true)
            {
                try
                {
                    Login.AdicionarConta(contas);
                    Login.addConta = false;
                }
                catch
                {
                    SistemBank.AdicionarConta(contas);
                    SistemBank.addConta = false;
                }
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Verifique se os campos foram preenchidos corretamente!", "Atenção!");
            }            
        }

        private void mskBanco_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        //--------------------------------end-Mover formulario & fechar form--------------------------------
    }
}
