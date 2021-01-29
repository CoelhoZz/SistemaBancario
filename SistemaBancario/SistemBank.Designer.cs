
namespace SistemaBancario
{
    partial class SistemBank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemBank));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.btnInicial = new System.Windows.Forms.Button();
            this.btnMinhaconta = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlSaldo = new System.Windows.Forms.Panel();
            this.xuiCardConta = new XanderUI.XUICard();
            this.label5 = new System.Windows.Forms.Label();
            this.cbmBox = new System.Windows.Forms.ComboBox();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDeposito = new System.Windows.Forms.Panel();
            this.txbDepCvv = new System.Windows.Forms.TextBox();
            this.txbDepBanco = new System.Windows.Forms.TextBox();
            this.btnFinalizarDeposito = new System.Windows.Forms.Button();
            this.mskDepValidade = new System.Windows.Forms.MaskedTextBox();
            this.mskDepNome = new System.Windows.Forms.MaskedTextBox();
            this.mskDepValor = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbmContaDeposito = new System.Windows.Forms.ComboBox();
            this.xuiCard2 = new XanderUI.XUICard();
            this.pnlMinhaConta = new System.Windows.Forms.Panel();
            this.cbmMinhasContas = new System.Windows.Forms.ComboBox();
            this.lblIDconta = new System.Windows.Forms.Label();
            this.btnAddViewPass = new System.Windows.Forms.Button();
            this.btnAddConfidentPass = new System.Windows.Forms.Button();
            this.xuiBtnRemoverConta = new XanderUI.XUIButton();
            this.xuiBtnAdicionar = new XanderUI.XUIButton();
            this.btnSalvarConta = new System.Windows.Forms.Button();
            this.mskUsuario = new System.Windows.Forms.MaskedTextBox();
            this.btnEditarConta = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mskEmail = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlSacar = new System.Windows.Forms.Panel();
            this.cbmFormasTransf = new System.Windows.Forms.ComboBox();
            this.mskSaqTransf = new System.Windows.Forms.MaskedTextBox();
            this.btnFinalizarSaque = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.mskSaqAssin = new System.Windows.Forms.MaskedTextBox();
            this.mskSaqSaldo = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cbmSacar = new System.Windows.Forms.ComboBox();
            this.xuiCard1 = new XanderUI.XUICard();
            this.pnlInicial = new System.Windows.Forms.Panel();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.lblMessageminicial = new System.Windows.Forms.Label();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.xuiGradientPanel1.SuspendLayout();
            this.pnlSaldo.SuspendLayout();
            this.pnlDeposito.SuspendLayout();
            this.pnlMinhaConta.SuspendLayout();
            this.pnlSacar.SuspendLayout();
            this.pnlInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 33);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 33);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(285, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sistema Bancario";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Montserrat Subrayada", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(714, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat Subrayada", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(667, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 7;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(95)))), ((int)(((byte)(157)))));
            this.xuiGradientPanel1.Controls.Add(this.btnInicial);
            this.xuiGradientPanel1.Controls.Add(this.btnMinhaconta);
            this.xuiGradientPanel1.Controls.Add(this.btnSacar);
            this.xuiGradientPanel1.Controls.Add(this.btnDepositar);
            this.xuiGradientPanel1.Controls.Add(this.btnSaldo);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 33);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.xuiGradientPanel1.Size = new System.Drawing.Size(170, 476);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 9;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            // 
            // btnInicial
            // 
            this.btnInicial.BackColor = System.Drawing.Color.Transparent;
            this.btnInicial.FlatAppearance.BorderSize = 0;
            this.btnInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicial.Location = new System.Drawing.Point(1, 6);
            this.btnInicial.Name = "btnInicial";
            this.btnInicial.Size = new System.Drawing.Size(167, 31);
            this.btnInicial.TabIndex = 4;
            this.btnInicial.Text = "&Inicial";
            this.btnInicial.UseVisualStyleBackColor = false;
            this.btnInicial.Click += new System.EventHandler(this.btnInicial_Click);
            // 
            // btnMinhaconta
            // 
            this.btnMinhaconta.BackColor = System.Drawing.Color.Transparent;
            this.btnMinhaconta.FlatAppearance.BorderSize = 0;
            this.btnMinhaconta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinhaconta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinhaconta.Location = new System.Drawing.Point(2, 269);
            this.btnMinhaconta.Name = "btnMinhaconta";
            this.btnMinhaconta.Size = new System.Drawing.Size(167, 37);
            this.btnMinhaconta.TabIndex = 0;
            this.btnMinhaconta.Text = "&Minha conta";
            this.btnMinhaconta.UseVisualStyleBackColor = false;
            this.btnMinhaconta.Click += new System.EventHandler(this.btnMinhaconta_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.Transparent;
            this.btnSacar.FlatAppearance.BorderSize = 0;
            this.btnSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(1, 228);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(167, 37);
            this.btnSacar.TabIndex = 3;
            this.btnSacar.Text = "&Sacar";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.Transparent;
            this.btnDepositar.FlatAppearance.BorderSize = 0;
            this.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(1, 185);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(167, 37);
            this.btnDepositar.TabIndex = 2;
            this.btnDepositar.Text = "&Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.Color.Transparent;
            this.btnSaldo.FlatAppearance.BorderSize = 0;
            this.btnSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldo.Location = new System.Drawing.Point(1, 142);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(167, 37);
            this.btnSaldo.TabIndex = 1;
            this.btnSaldo.Text = "&Saldo";
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 502);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 10);
            this.panel3.TabIndex = 10;
            // 
            // pnlSaldo
            // 
            this.pnlSaldo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSaldo.BackgroundImage")));
            this.pnlSaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSaldo.Controls.Add(this.xuiCardConta);
            this.pnlSaldo.Controls.Add(this.label5);
            this.pnlSaldo.Controls.Add(this.cbmBox);
            this.pnlSaldo.Controls.Add(this.lblSaldoTotal);
            this.pnlSaldo.Controls.Add(this.label1);
            this.pnlSaldo.Location = new System.Drawing.Point(202, 52);
            this.pnlSaldo.Name = "pnlSaldo";
            this.pnlSaldo.Size = new System.Drawing.Size(503, 426);
            this.pnlSaldo.TabIndex = 6;
            this.pnlSaldo.Visible = false;
            // 
            // xuiCardConta
            // 
            this.xuiCardConta.BackColor = System.Drawing.Color.Transparent;
            this.xuiCardConta.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCardConta.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.xuiCardConta.ForeColor = System.Drawing.Color.White;
            this.xuiCardConta.Location = new System.Drawing.Point(98, 158);
            this.xuiCardConta.Name = "xuiCardConta";
            this.xuiCardConta.Size = new System.Drawing.Size(320, 170);
            this.xuiCardConta.TabIndex = 25;
            this.xuiCardConta.Text = "xuiCard3";
            this.xuiCardConta.Text1 = "Saldo :";
            this.xuiCardConta.Text2 = "1234 5678 9101 1121";
            this.xuiCardConta.Text3 = "Tipo Conta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Conta:";
            // 
            // cbmBox
            // 
            this.cbmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmBox.FormattingEnabled = true;
            this.cbmBox.Location = new System.Drawing.Point(146, 332);
            this.cbmBox.Name = "cbmBox";
            this.cbmBox.Size = new System.Drawing.Size(276, 29);
            this.cbmBox.TabIndex = 21;
            this.cbmBox.SelectedIndexChanged += new System.EventHandler(this.cbmBox_SelectedIndexChanged);
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.Location = new System.Drawing.Point(259, 76);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(39, 47);
            this.lblSaldoTotal.TabIndex = 1;
            this.lblSaldoTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo total:";
            // 
            // pnlDeposito
            // 
            this.pnlDeposito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDeposito.BackgroundImage")));
            this.pnlDeposito.Controls.Add(this.txbDepCvv);
            this.pnlDeposito.Controls.Add(this.txbDepBanco);
            this.pnlDeposito.Controls.Add(this.btnFinalizarDeposito);
            this.pnlDeposito.Controls.Add(this.mskDepValidade);
            this.pnlDeposito.Controls.Add(this.mskDepNome);
            this.pnlDeposito.Controls.Add(this.mskDepValor);
            this.pnlDeposito.Controls.Add(this.label7);
            this.pnlDeposito.Controls.Add(this.label2);
            this.pnlDeposito.Controls.Add(this.label6);
            this.pnlDeposito.Controls.Add(this.cbmContaDeposito);
            this.pnlDeposito.Controls.Add(this.xuiCard2);
            this.pnlDeposito.Location = new System.Drawing.Point(202, 52);
            this.pnlDeposito.Name = "pnlDeposito";
            this.pnlDeposito.Size = new System.Drawing.Size(503, 427);
            this.pnlDeposito.TabIndex = 4;
            this.pnlDeposito.Visible = false;
            // 
            // txbDepCvv
            // 
            this.txbDepCvv.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepCvv.Location = new System.Drawing.Point(331, 334);
            this.txbDepCvv.MaxLength = 3;
            this.txbDepCvv.Name = "txbDepCvv";
            this.txbDepCvv.Size = new System.Drawing.Size(81, 27);
            this.txbDepCvv.TabIndex = 5;
            this.txbDepCvv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_SoNumero);
            // 
            // txbDepBanco
            // 
            this.txbDepBanco.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepBanco.Location = new System.Drawing.Point(105, 262);
            this.txbDepBanco.MaxLength = 16;
            this.txbDepBanco.Name = "txbDepBanco";
            this.txbDepBanco.Size = new System.Drawing.Size(211, 27);
            this.txbDepBanco.TabIndex = 3;
            this.txbDepBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_SoNumero);
            // 
            // btnFinalizarDeposito
            // 
            this.btnFinalizarDeposito.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarDeposito.Location = new System.Drawing.Point(175, 380);
            this.btnFinalizarDeposito.Name = "btnFinalizarDeposito";
            this.btnFinalizarDeposito.Size = new System.Drawing.Size(153, 28);
            this.btnFinalizarDeposito.TabIndex = 6;
            this.btnFinalizarDeposito.Text = "&Finalizar";
            this.btnFinalizarDeposito.UseVisualStyleBackColor = false;
            this.btnFinalizarDeposito.Click += new System.EventHandler(this.btnFinalizarDeposito_Click);
            // 
            // mskDepValidade
            // 
            this.mskDepValidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDepValidade.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDepValidade.Location = new System.Drawing.Point(166, 334);
            this.mskDepValidade.Mask = "00/0000";
            this.mskDepValidade.Name = "mskDepValidade";
            this.mskDepValidade.Size = new System.Drawing.Size(76, 27);
            this.mskDepValidade.TabIndex = 4;
            this.mskDepValidade.ValidatingType = typeof(System.DateTime);
            // 
            // mskDepNome
            // 
            this.mskDepNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDepNome.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDepNome.Location = new System.Drawing.Point(157, 206);
            this.mskDepNome.Name = "mskDepNome";
            this.mskDepNome.Size = new System.Drawing.Size(253, 27);
            this.mskDepNome.TabIndex = 2;
            this.mskDepNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_SoLetra);
            // 
            // mskDepValor
            // 
            this.mskDepValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDepValor.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDepValor.Location = new System.Drawing.Point(188, 161);
            this.mskDepValor.Name = "mskDepValor";
            this.mskDepValor.Size = new System.Drawing.Size(100, 27);
            this.mskDepValor.TabIndex = 1;
            this.mskDepValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_SoNumero);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 35);
            this.label2.TabIndex = 24;
            this.label2.Text = "Deposito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Conta:";
            // 
            // cbmContaDeposito
            // 
            this.cbmContaDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmContaDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmContaDeposito.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmContaDeposito.FormattingEnabled = true;
            this.cbmContaDeposito.Location = new System.Drawing.Point(188, 117);
            this.cbmContaDeposito.Name = "cbmContaDeposito";
            this.cbmContaDeposito.Size = new System.Drawing.Size(230, 29);
            this.cbmContaDeposito.TabIndex = 0;
            // 
            // xuiCard2
            // 
            this.xuiCard2.BackColor = System.Drawing.Color.Transparent;
            this.xuiCard2.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCard2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.xuiCard2.ForeColor = System.Drawing.Color.White;
            this.xuiCard2.Location = new System.Drawing.Point(101, 200);
            this.xuiCard2.Name = "xuiCard2";
            this.xuiCard2.Size = new System.Drawing.Size(320, 170);
            this.xuiCard2.TabIndex = 35;
            this.xuiCard2.Text = "xuiCard2";
            this.xuiCard2.Text1 = "Nome";
            this.xuiCard2.Text2 = "Numero Do Cartão";
            this.xuiCard2.Text3 = "Validade                                    CVV";
            // 
            // pnlMinhaConta
            // 
            this.pnlMinhaConta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMinhaConta.BackgroundImage")));
            this.pnlMinhaConta.Controls.Add(this.cbmMinhasContas);
            this.pnlMinhaConta.Controls.Add(this.lblIDconta);
            this.pnlMinhaConta.Controls.Add(this.btnAddViewPass);
            this.pnlMinhaConta.Controls.Add(this.btnAddConfidentPass);
            this.pnlMinhaConta.Controls.Add(this.xuiBtnRemoverConta);
            this.pnlMinhaConta.Controls.Add(this.xuiBtnAdicionar);
            this.pnlMinhaConta.Controls.Add(this.btnSalvarConta);
            this.pnlMinhaConta.Controls.Add(this.mskUsuario);
            this.pnlMinhaConta.Controls.Add(this.btnEditarConta);
            this.pnlMinhaConta.Controls.Add(this.label13);
            this.pnlMinhaConta.Controls.Add(this.mskCpf);
            this.pnlMinhaConta.Controls.Add(this.label14);
            this.pnlMinhaConta.Controls.Add(this.mskEmail);
            this.pnlMinhaConta.Controls.Add(this.label15);
            this.pnlMinhaConta.Controls.Add(this.mskSenha);
            this.pnlMinhaConta.Controls.Add(this.label16);
            this.pnlMinhaConta.Controls.Add(this.label17);
            this.pnlMinhaConta.Controls.Add(this.label18);
            this.pnlMinhaConta.Location = new System.Drawing.Point(202, 52);
            this.pnlMinhaConta.Name = "pnlMinhaConta";
            this.pnlMinhaConta.Size = new System.Drawing.Size(504, 427);
            this.pnlMinhaConta.TabIndex = 0;
            this.pnlMinhaConta.Visible = false;
            // 
            // cbmMinhasContas
            // 
            this.cbmMinhasContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmMinhasContas.Enabled = false;
            this.cbmMinhasContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmMinhasContas.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmMinhasContas.FormattingEnabled = true;
            this.cbmMinhasContas.Location = new System.Drawing.Point(175, 269);
            this.cbmMinhasContas.Name = "cbmMinhasContas";
            this.cbmMinhasContas.Size = new System.Drawing.Size(227, 29);
            this.cbmMinhasContas.TabIndex = 5;
            // 
            // lblIDconta
            // 
            this.lblIDconta.AutoSize = true;
            this.lblIDconta.Location = new System.Drawing.Point(216, 278);
            this.lblIDconta.Name = "lblIDconta";
            this.lblIDconta.Size = new System.Drawing.Size(0, 13);
            this.lblIDconta.TabIndex = 41;
            // 
            // btnAddViewPass
            // 
            this.btnAddViewPass.BackColor = System.Drawing.Color.White;
            this.btnAddViewPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddViewPass.BackgroundImage")));
            this.btnAddViewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddViewPass.FlatAppearance.BorderSize = 0;
            this.btnAddViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddViewPass.Location = new System.Drawing.Point(371, 148);
            this.btnAddViewPass.Name = "btnAddViewPass";
            this.btnAddViewPass.Size = new System.Drawing.Size(28, 24);
            this.btnAddViewPass.TabIndex = 39;
            this.btnAddViewPass.UseVisualStyleBackColor = false;
            this.btnAddViewPass.Click += new System.EventHandler(this.btnAddViewPass_Click);
            // 
            // btnAddConfidentPass
            // 
            this.btnAddConfidentPass.BackColor = System.Drawing.Color.White;
            this.btnAddConfidentPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddConfidentPass.BackgroundImage")));
            this.btnAddConfidentPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddConfidentPass.FlatAppearance.BorderSize = 0;
            this.btnAddConfidentPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConfidentPass.Location = new System.Drawing.Point(373, 148);
            this.btnAddConfidentPass.Name = "btnAddConfidentPass";
            this.btnAddConfidentPass.Size = new System.Drawing.Size(28, 24);
            this.btnAddConfidentPass.TabIndex = 40;
            this.btnAddConfidentPass.UseVisualStyleBackColor = false;
            this.btnAddConfidentPass.Visible = false;
            this.btnAddConfidentPass.Click += new System.EventHandler(this.btnAddConfidentPass_Click);
            // 
            // xuiBtnRemoverConta
            // 
            this.xuiBtnRemoverConta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiBtnRemoverConta.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiBtnRemoverConta.ButtonImage")));
            this.xuiBtnRemoverConta.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiBtnRemoverConta.ButtonText = "Remover";
            this.xuiBtnRemoverConta.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiBtnRemoverConta.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnRemoverConta.CornerRadius = 5;
            this.xuiBtnRemoverConta.Enabled = false;
            this.xuiBtnRemoverConta.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtnRemoverConta.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiBtnRemoverConta.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnRemoverConta.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiBtnRemoverConta.Location = new System.Drawing.Point(176, 305);
            this.xuiBtnRemoverConta.Name = "xuiBtnRemoverConta";
            this.xuiBtnRemoverConta.Size = new System.Drawing.Size(106, 25);
            this.xuiBtnRemoverConta.TabIndex = 9;
            this.xuiBtnRemoverConta.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnRemoverConta.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtnRemoverConta.Click += new System.EventHandler(this.xuiBtnRemoverConta_Click);
            // 
            // xuiBtnAdicionar
            // 
            this.xuiBtnAdicionar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiBtnAdicionar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiBtnAdicionar.ButtonImage")));
            this.xuiBtnAdicionar.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiBtnAdicionar.ButtonText = "Conta";
            this.xuiBtnAdicionar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiBtnAdicionar.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnAdicionar.CornerRadius = 5;
            this.xuiBtnAdicionar.Enabled = false;
            this.xuiBtnAdicionar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtnAdicionar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiBtnAdicionar.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnAdicionar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiBtnAdicionar.Location = new System.Drawing.Point(285, 303);
            this.xuiBtnAdicionar.Name = "xuiBtnAdicionar";
            this.xuiBtnAdicionar.Size = new System.Drawing.Size(115, 25);
            this.xuiBtnAdicionar.TabIndex = 8;
            this.xuiBtnAdicionar.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnAdicionar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtnAdicionar.Click += new System.EventHandler(this.xuiBtnAdicionar_Click);
            // 
            // btnSalvarConta
            // 
            this.btnSalvarConta.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarConta.Enabled = false;
            this.btnSalvarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarConta.Location = new System.Drawing.Point(259, 363);
            this.btnSalvarConta.Name = "btnSalvarConta";
            this.btnSalvarConta.Size = new System.Drawing.Size(153, 28);
            this.btnSalvarConta.TabIndex = 6;
            this.btnSalvarConta.Text = "&Salvar";
            this.btnSalvarConta.UseVisualStyleBackColor = false;
            this.btnSalvarConta.Click += new System.EventHandler(this.btnSalvarConta_Click);
            // 
            // mskUsuario
            // 
            this.mskUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskUsuario.Enabled = false;
            this.mskUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskUsuario.Location = new System.Drawing.Point(175, 104);
            this.mskUsuario.Name = "mskUsuario";
            this.mskUsuario.Size = new System.Drawing.Size(227, 27);
            this.mskUsuario.TabIndex = 1;
            // 
            // btnEditarConta
            // 
            this.btnEditarConta.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarConta.Location = new System.Drawing.Point(101, 363);
            this.btnEditarConta.Name = "btnEditarConta";
            this.btnEditarConta.Size = new System.Drawing.Size(153, 28);
            this.btnEditarConta.TabIndex = 7;
            this.btnEditarConta.Text = "&Editar";
            this.btnEditarConta.UseVisualStyleBackColor = false;
            this.btnEditarConta.Click += new System.EventHandler(this.btnEditarConta_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(106, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Contas:";
            // 
            // mskCpf
            // 
            this.mskCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCpf.Enabled = false;
            this.mskCpf.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(175, 229);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(227, 27);
            this.mskCpf.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(124, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "CPF:";
            // 
            // mskEmail
            // 
            this.mskEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskEmail.Enabled = false;
            this.mskEmail.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskEmail.Location = new System.Drawing.Point(175, 187);
            this.mskEmail.Name = "mskEmail";
            this.mskEmail.Size = new System.Drawing.Size(227, 27);
            this.mskEmail.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(117, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 18);
            this.label15.TabIndex = 27;
            this.label15.Text = "Email:";
            // 
            // mskSenha
            // 
            this.mskSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskSenha.Enabled = false;
            this.mskSenha.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSenha.Location = new System.Drawing.Point(175, 147);
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.PasswordChar = '*';
            this.mskSenha.Size = new System.Drawing.Size(227, 27);
            this.mskSenha.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(112, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 18);
            this.label16.TabIndex = 25;
            this.label16.Text = "Senha:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(168, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(182, 35);
            this.label17.TabIndex = 24;
            this.label17.Text = "Minha Conta";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(102, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 18);
            this.label18.TabIndex = 23;
            this.label18.Text = "Usuario:";
            // 
            // pnlSacar
            // 
            this.pnlSacar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSacar.BackgroundImage")));
            this.pnlSacar.Controls.Add(this.cbmFormasTransf);
            this.pnlSacar.Controls.Add(this.mskSaqTransf);
            this.pnlSacar.Controls.Add(this.btnFinalizarSaque);
            this.pnlSacar.Controls.Add(this.label21);
            this.pnlSacar.Controls.Add(this.mskSaqAssin);
            this.pnlSacar.Controls.Add(this.mskSaqSaldo);
            this.pnlSacar.Controls.Add(this.label22);
            this.pnlSacar.Controls.Add(this.label23);
            this.pnlSacar.Controls.Add(this.label24);
            this.pnlSacar.Controls.Add(this.cbmSacar);
            this.pnlSacar.Controls.Add(this.xuiCard1);
            this.pnlSacar.Location = new System.Drawing.Point(202, 53);
            this.pnlSacar.Name = "pnlSacar";
            this.pnlSacar.Size = new System.Drawing.Size(503, 427);
            this.pnlSacar.TabIndex = 1;
            this.pnlSacar.Visible = false;
            // 
            // cbmFormasTransf
            // 
            this.cbmFormasTransf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmFormasTransf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmFormasTransf.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmFormasTransf.FormattingEnabled = true;
            this.cbmFormasTransf.Items.AddRange(new object[] {
            "CPF",
            "TELEFONE"});
            this.cbmFormasTransf.Location = new System.Drawing.Point(231, 214);
            this.cbmFormasTransf.Name = "cbmFormasTransf";
            this.cbmFormasTransf.Size = new System.Drawing.Size(224, 28);
            this.cbmFormasTransf.TabIndex = 2;
            this.cbmFormasTransf.SelectedIndexChanged += new System.EventHandler(this.cbmFormasTransf_SelectedIndexChanged);
            // 
            // mskSaqTransf
            // 
            this.mskSaqTransf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskSaqTransf.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSaqTransf.Location = new System.Drawing.Point(231, 248);
            this.mskSaqTransf.Name = "mskSaqTransf";
            this.mskSaqTransf.Size = new System.Drawing.Size(224, 33);
            this.mskSaqTransf.TabIndex = 3;
            this.mskSaqTransf.Visible = false;
            // 
            // btnFinalizarSaque
            // 
            this.btnFinalizarSaque.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarSaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarSaque.Location = new System.Drawing.Point(183, 379);
            this.btnFinalizarSaque.Name = "btnFinalizarSaque";
            this.btnFinalizarSaque.Size = new System.Drawing.Size(153, 28);
            this.btnFinalizarSaque.TabIndex = 5;
            this.btnFinalizarSaque.Text = "&Finalizar";
            this.btnFinalizarSaque.UseVisualStyleBackColor = false;
            this.btnFinalizarSaque.Click += new System.EventHandler(this.btnFinalizarSaque_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(35, 142);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 18);
            this.label21.TabIndex = 27;
            // 
            // mskSaqAssin
            // 
            this.mskSaqAssin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskSaqAssin.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSaqAssin.Location = new System.Drawing.Point(243, 293);
            this.mskSaqAssin.Name = "mskSaqAssin";
            this.mskSaqAssin.Size = new System.Drawing.Size(78, 30);
            this.mskSaqAssin.TabIndex = 4;
            // 
            // mskSaqSaldo
            // 
            this.mskSaqSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskSaqSaldo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSaqSaldo.Location = new System.Drawing.Point(191, 154);
            this.mskSaqSaldo.Mask = "$";
            this.mskSaqSaldo.Name = "mskSaqSaldo";
            this.mskSaqSaldo.Size = new System.Drawing.Size(107, 27);
            this.mskSaqSaldo.TabIndex = 1;
            this.mskSaqSaldo.ValidatingType = typeof(int);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(142, 159);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 18);
            this.label22.TabIndex = 25;
            this.label22.Text = "Valor:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(213, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 35);
            this.label23.TabIndex = 24;
            this.label23.Text = "Sacar";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(136, 117);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 18);
            this.label24.TabIndex = 23;
            this.label24.Text = "Conta:";
            // 
            // cbmSacar
            // 
            this.cbmSacar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmSacar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmSacar.FormattingEnabled = true;
            this.cbmSacar.Location = new System.Drawing.Point(191, 111);
            this.cbmSacar.Name = "cbmSacar";
            this.cbmSacar.Size = new System.Drawing.Size(230, 29);
            this.cbmSacar.TabIndex = 0;
            this.cbmSacar.SelectedIndexChanged += new System.EventHandler(this.cbmSacar_SelectedIndexChanged);
            // 
            // xuiCard1
            // 
            this.xuiCard1.BackColor = System.Drawing.Color.Transparent;
            this.xuiCard1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCard1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.xuiCard1.ForeColor = System.Drawing.Color.White;
            this.xuiCard1.Location = new System.Drawing.Point(38, 208);
            this.xuiCard1.Name = "xuiCard1";
            this.xuiCard1.Size = new System.Drawing.Size(429, 161);
            this.xuiCard1.TabIndex = 37;
            this.xuiCard1.Text = "xuiCard1";
            this.xuiCard1.Text1 = "Formas de Transferencia:";
            this.xuiCard1.Text2 = "Assinatura digital";
            this.xuiCard1.Text3 = "";
            // 
            // pnlInicial
            // 
            this.pnlInicial.BackColor = System.Drawing.Color.Transparent;
            this.pnlInicial.Controls.Add(this.lblRelogio);
            this.pnlInicial.Controls.Add(this.lblMessageminicial);
            this.pnlInicial.Location = new System.Drawing.Point(202, 53);
            this.pnlInicial.Name = "pnlInicial";
            this.pnlInicial.Size = new System.Drawing.Size(503, 427);
            this.pnlInicial.TabIndex = 2;
            this.pnlInicial.Visible = false;
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Font = new System.Drawing.Font("MS Reference Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRelogio.Location = new System.Drawing.Point(81, 83);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(338, 118);
            this.lblRelogio.TabIndex = 1;
            this.lblRelogio.Text = "00:00";
            // 
            // lblMessageminicial
            // 
            this.lblMessageminicial.AutoSize = true;
            this.lblMessageminicial.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageminicial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMessageminicial.Location = new System.Drawing.Point(98, 216);
            this.lblMessageminicial.Name = "lblMessageminicial";
            this.lblMessageminicial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessageminicial.Size = new System.Drawing.Size(303, 46);
            this.lblMessageminicial.TabIndex = 0;
            this.lblMessageminicial.Text = "Seja bem-vindo!!";
            this.lblMessageminicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRelogio
            // 
            this.timerRelogio.Enabled = true;
            this.timerRelogio.Interval = 1000;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // SistemBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(741, 512);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.xuiGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMinhaConta);
            this.Controls.Add(this.pnlSacar);
            this.Controls.Add(this.pnlInicial);
            this.Controls.Add(this.pnlDeposito);
            this.Controls.Add(this.pnlSaldo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SistemBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SistemBank";
            this.Load += new System.EventHandler(this.SistemBank_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.xuiGradientPanel1.ResumeLayout(false);
            this.pnlSaldo.ResumeLayout(false);
            this.pnlSaldo.PerformLayout();
            this.pnlDeposito.ResumeLayout(false);
            this.pnlDeposito.PerformLayout();
            this.pnlMinhaConta.ResumeLayout(false);
            this.pnlMinhaConta.PerformLayout();
            this.pnlSacar.ResumeLayout(false);
            this.pnlSacar.PerformLayout();
            this.pnlInicial.ResumeLayout(false);
            this.pnlInicial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExit;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinhaconta;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Panel pnlSaldo;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbmBox;
        private System.Windows.Forms.Panel pnlDeposito;
        private System.Windows.Forms.Button btnFinalizarDeposito;
        private System.Windows.Forms.MaskedTextBox mskDepValidade;
        private System.Windows.Forms.MaskedTextBox mskDepNome;
        private System.Windows.Forms.MaskedTextBox mskDepValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbmContaDeposito;
        private System.Windows.Forms.Panel pnlMinhaConta;
        private System.Windows.Forms.Button btnSalvarConta;
        private System.Windows.Forms.ComboBox cbmMinhasContas;
        private System.Windows.Forms.MaskedTextBox mskUsuario;
        private System.Windows.Forms.Button btnEditarConta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mskEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mskSenha;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private XanderUI.XUIButton xuiBtnRemoverConta;
        private XanderUI.XUIButton xuiBtnAdicionar;
        private System.Windows.Forms.Panel pnlSacar;
        private System.Windows.Forms.Button btnFinalizarSaque;
        private System.Windows.Forms.MaskedTextBox mskSaqAssin;
        private System.Windows.Forms.MaskedTextBox mskSaqTransf;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox mskSaqSaldo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbmSacar;
        private System.Windows.Forms.Panel pnlInicial;
        private System.Windows.Forms.Label lblMessageminicial;
        private System.Windows.Forms.Button btnInicial;
        private System.Windows.Forms.Button btnAddViewPass;
        private System.Windows.Forms.Button btnAddConfidentPass;
        private System.Windows.Forms.Label lblRelogio;
        private XanderUI.XUICard xuiCard1;
        private XanderUI.XUICard xuiCard2;
        private System.Windows.Forms.Label lblIDconta;
        private System.Windows.Forms.TextBox txbDepCvv;
        private System.Windows.Forms.TextBox txbDepBanco;
        private XanderUI.XUICard xuiCardConta;
        private System.Windows.Forms.ComboBox cbmFormasTransf;
        private System.Windows.Forms.Timer timerRelogio;
    }
}