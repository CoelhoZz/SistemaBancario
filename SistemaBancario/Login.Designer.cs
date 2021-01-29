
namespace SistemaBancario
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mskUser = new System.Windows.Forms.MaskedTextBox();
            this.mskPass = new System.Windows.Forms.MaskedTextBox();
            this.xuiBtnLogar = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.xuiBntAdd = new XanderUI.XUIButton();
            this.pnlEntrar = new System.Windows.Forms.Panel();
            this.btnViewPass = new System.Windows.Forms.Button();
            this.btnConfidentPass = new System.Windows.Forms.Button();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.picBVerificado = new System.Windows.Forms.PictureBox();
            this.xuiBntVoltar = new XanderUI.XUIButton();
            this.xuiBtnConta = new XanderUI.XUIButton();
            this.btnAddViewPass = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddConfidentPass = new System.Windows.Forms.Button();
            this.mskAdEmail = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskAdCpf = new System.Windows.Forms.MaskedTextBox();
            this.xuiBtnFinalizar = new XanderUI.XUIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskAdPass = new System.Windows.Forms.MaskedTextBox();
            this.mskAdUser = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlEntrar.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBVerificado)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 7;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(95)))), ((int)(((byte)(157)))));
            this.xuiBanner1.BorderColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.White;
            this.xuiBanner1.Location = new System.Drawing.Point(12, 12);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(184, 312);
            this.xuiBanner1.TabIndex = 0;
            this.xuiBanner1.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 33);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 33);
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
            this.label3.Location = new System.Drawing.Point(272, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sistema Bancario";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Montserrat Subrayada", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(667, 4);
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
            // mskUser
            // 
            this.mskUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.mskUser.Location = new System.Drawing.Point(126, 35);
            this.mskUser.Name = "mskUser";
            this.mskUser.Size = new System.Drawing.Size(195, 28);
            this.mskUser.TabIndex = 0;
            // 
            // mskPass
            // 
            this.mskPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.mskPass.Location = new System.Drawing.Point(126, 81);
            this.mskPass.Name = "mskPass";
            this.mskPass.PasswordChar = '*';
            this.mskPass.Size = new System.Drawing.Size(195, 28);
            this.mskPass.TabIndex = 1;
            // 
            // xuiBtnLogar
            // 
            this.xuiBtnLogar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiBtnLogar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiBtnLogar.ButtonImage")));
            this.xuiBtnLogar.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiBtnLogar.ButtonText = "Login";
            this.xuiBtnLogar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiBtnLogar.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnLogar.CornerRadius = 5;
            this.xuiBtnLogar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtnLogar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiBtnLogar.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnLogar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiBtnLogar.Location = new System.Drawing.Point(34, 143);
            this.xuiBtnLogar.Name = "xuiBtnLogar";
            this.xuiBtnLogar.Size = new System.Drawing.Size(166, 41);
            this.xuiBtnLogar.TabIndex = 2;
            this.xuiBtnLogar.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnLogar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtnLogar.Click += new System.EventHandler(this.xuiBtnLogar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(82, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pass:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(194)))), ((int)(((byte)(237)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 10);
            this.panel3.TabIndex = 9;
            // 
            // xuiBntAdd
            // 
            this.xuiBntAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiBntAdd.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiBntAdd.ButtonImage")));
            this.xuiBntAdd.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiBntAdd.ButtonText = "Adicionar Conta";
            this.xuiBntAdd.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiBntAdd.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBntAdd.CornerRadius = 5;
            this.xuiBntAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBntAdd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiBntAdd.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBntAdd.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiBntAdd.Location = new System.Drawing.Point(215, 143);
            this.xuiBntAdd.Name = "xuiBntAdd";
            this.xuiBntAdd.Size = new System.Drawing.Size(166, 41);
            this.xuiBntAdd.TabIndex = 3;
            this.xuiBntAdd.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBntAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBntAdd.Click += new System.EventHandler(this.xuiBntAdd_Click);
            // 
            // pnlEntrar
            // 
            this.pnlEntrar.Controls.Add(this.btnViewPass);
            this.pnlEntrar.Controls.Add(this.btnConfidentPass);
            this.pnlEntrar.Controls.Add(this.xuiBntAdd);
            this.pnlEntrar.Controls.Add(this.label1);
            this.pnlEntrar.Controls.Add(this.xuiBtnLogar);
            this.pnlEntrar.Controls.Add(this.label2);
            this.pnlEntrar.Controls.Add(this.mskPass);
            this.pnlEntrar.Controls.Add(this.mskUser);
            this.pnlEntrar.Location = new System.Drawing.Point(243, 67);
            this.pnlEntrar.Name = "pnlEntrar";
            this.pnlEntrar.Size = new System.Drawing.Size(400, 230);
            this.pnlEntrar.TabIndex = 11;
            // 
            // btnViewPass
            // 
            this.btnViewPass.BackColor = System.Drawing.Color.White;
            this.btnViewPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewPass.BackgroundImage")));
            this.btnViewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewPass.FlatAppearance.BorderSize = 0;
            this.btnViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPass.Location = new System.Drawing.Point(289, 81);
            this.btnViewPass.Name = "btnViewPass";
            this.btnViewPass.Size = new System.Drawing.Size(32, 28);
            this.btnViewPass.TabIndex = 13;
            this.btnViewPass.UseVisualStyleBackColor = false;
            this.btnViewPass.Click += new System.EventHandler(this.btnViewPass_Click);
            // 
            // btnConfidentPass
            // 
            this.btnConfidentPass.BackColor = System.Drawing.Color.White;
            this.btnConfidentPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfidentPass.BackgroundImage")));
            this.btnConfidentPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfidentPass.FlatAppearance.BorderSize = 0;
            this.btnConfidentPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfidentPass.Location = new System.Drawing.Point(289, 81);
            this.btnConfidentPass.Name = "btnConfidentPass";
            this.btnConfidentPass.Size = new System.Drawing.Size(32, 28);
            this.btnConfidentPass.TabIndex = 14;
            this.btnConfidentPass.UseVisualStyleBackColor = false;
            this.btnConfidentPass.Visible = false;
            this.btnConfidentPass.Click += new System.EventHandler(this.btnConfidentPass_Click);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Controls.Add(this.picBVerificado);
            this.pnlCadastro.Controls.Add(this.xuiBntVoltar);
            this.pnlCadastro.Controls.Add(this.xuiBtnConta);
            this.pnlCadastro.Controls.Add(this.btnAddViewPass);
            this.pnlCadastro.Controls.Add(this.label7);
            this.pnlCadastro.Controls.Add(this.btnAddConfidentPass);
            this.pnlCadastro.Controls.Add(this.mskAdEmail);
            this.pnlCadastro.Controls.Add(this.label6);
            this.pnlCadastro.Controls.Add(this.mskAdCpf);
            this.pnlCadastro.Controls.Add(this.xuiBtnFinalizar);
            this.pnlCadastro.Controls.Add(this.label4);
            this.pnlCadastro.Controls.Add(this.label5);
            this.pnlCadastro.Controls.Add(this.mskAdPass);
            this.pnlCadastro.Controls.Add(this.mskAdUser);
            this.pnlCadastro.Location = new System.Drawing.Point(242, 67);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(400, 230);
            this.pnlCadastro.TabIndex = 12;
            this.pnlCadastro.Visible = false;
            // 
            // picBVerificado
            // 
            this.picBVerificado.Image = ((System.Drawing.Image)(resources.GetObject("picBVerificado.Image")));
            this.picBVerificado.Location = new System.Drawing.Point(97, 136);
            this.picBVerificado.Name = "picBVerificado";
            this.picBVerificado.Size = new System.Drawing.Size(30, 25);
            this.picBVerificado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBVerificado.TabIndex = 13;
            this.picBVerificado.TabStop = false;
            this.picBVerificado.Visible = false;
            // 
            // xuiBntVoltar
            // 
            this.xuiBntVoltar.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiBntVoltar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiBntVoltar.ButtonImage")));
            this.xuiBntVoltar.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiBntVoltar.ButtonText = "";
            this.xuiBntVoltar.ClickBackColor = System.Drawing.Color.Silver;
            this.xuiBntVoltar.ClickTextColor = System.Drawing.Color.DarkGray;
            this.xuiBntVoltar.CornerRadius = 15;
            this.xuiBntVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiBntVoltar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBntVoltar.HoverBackgroundColor = System.Drawing.Color.LightGray;
            this.xuiBntVoltar.HoverTextColor = System.Drawing.Color.LightGray;
            this.xuiBntVoltar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiBntVoltar.Location = new System.Drawing.Point(4, 3);
            this.xuiBntVoltar.Name = "xuiBntVoltar";
            this.xuiBntVoltar.Size = new System.Drawing.Size(37, 36);
            this.xuiBntVoltar.TabIndex = 6;
            this.xuiBntVoltar.TextColor = System.Drawing.Color.Transparent;
            this.xuiBntVoltar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBntVoltar.Click += new System.EventHandler(this.xuiBntVoltar_Click);
            // 
            // xuiBtnConta
            // 
            this.xuiBtnConta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiBtnConta.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiBtnConta.ButtonImage")));
            this.xuiBtnConta.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiBtnConta.ButtonText = "Conta";
            this.xuiBtnConta.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.xuiBtnConta.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnConta.CornerRadius = 5;
            this.xuiBtnConta.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtnConta.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xuiBtnConta.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnConta.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiBtnConta.Location = new System.Drawing.Point(133, 136);
            this.xuiBtnConta.Name = "xuiBtnConta";
            this.xuiBtnConta.Size = new System.Drawing.Size(195, 25);
            this.xuiBtnConta.TabIndex = 4;
            this.xuiBtnConta.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiBtnConta.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtnConta.Click += new System.EventHandler(this.xuiBtnConta_Click);
            // 
            // btnAddViewPass
            // 
            this.btnAddViewPass.BackColor = System.Drawing.Color.White;
            this.btnAddViewPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddViewPass.BackgroundImage")));
            this.btnAddViewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddViewPass.FlatAppearance.BorderSize = 0;
            this.btnAddViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddViewPass.Location = new System.Drawing.Point(300, 44);
            this.btnAddViewPass.Name = "btnAddViewPass";
            this.btnAddViewPass.Size = new System.Drawing.Size(28, 24);
            this.btnAddViewPass.TabIndex = 17;
            this.btnAddViewPass.UseVisualStyleBackColor = false;
            this.btnAddViewPass.Click += new System.EventHandler(this.btnAddViewPass_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(82, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email:";
            // 
            // btnAddConfidentPass
            // 
            this.btnAddConfidentPass.BackColor = System.Drawing.Color.White;
            this.btnAddConfidentPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddConfidentPass.BackgroundImage")));
            this.btnAddConfidentPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddConfidentPass.FlatAppearance.BorderSize = 0;
            this.btnAddConfidentPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConfidentPass.Location = new System.Drawing.Point(300, 44);
            this.btnAddConfidentPass.Name = "btnAddConfidentPass";
            this.btnAddConfidentPass.Size = new System.Drawing.Size(28, 24);
            this.btnAddConfidentPass.TabIndex = 18;
            this.btnAddConfidentPass.UseVisualStyleBackColor = false;
            this.btnAddConfidentPass.Visible = false;
            this.btnAddConfidentPass.Click += new System.EventHandler(this.btnAddConfidentPass_Click);
            // 
            // mskAdEmail
            // 
            this.mskAdEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskAdEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAdEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.mskAdEmail.Location = new System.Drawing.Point(133, 104);
            this.mskAdEmail.Name = "mskAdEmail";
            this.mskAdEmail.Size = new System.Drawing.Size(195, 24);
            this.mskAdEmail.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(93, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "CPF:";
            // 
            // mskAdCpf
            // 
            this.mskAdCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskAdCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAdCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.mskAdCpf.Location = new System.Drawing.Point(133, 74);
            this.mskAdCpf.Mask = "000,000,000-00";
            this.mskAdCpf.Name = "mskAdCpf";
            this.mskAdCpf.Size = new System.Drawing.Size(195, 24);
            this.mskAdCpf.TabIndex = 2;
            // 
            // xuiBtnFinalizar
            // 
            this.xuiBtnFinalizar.BackgroundColor = System.Drawing.Color.White;
            this.xuiBtnFinalizar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiBtnFinalizar.ButtonImage")));
            this.xuiBtnFinalizar.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiBtnFinalizar.ButtonText = "Finalizar";
            this.xuiBtnFinalizar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiBtnFinalizar.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiBtnFinalizar.CornerRadius = 5;
            this.xuiBtnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiBtnFinalizar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtnFinalizar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiBtnFinalizar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiBtnFinalizar.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiBtnFinalizar.Location = new System.Drawing.Point(127, 177);
            this.xuiBtnFinalizar.Name = "xuiBtnFinalizar";
            this.xuiBtnFinalizar.Size = new System.Drawing.Size(166, 41);
            this.xuiBtnFinalizar.TabIndex = 5;
            this.xuiBtnFinalizar.TextColor = System.Drawing.Color.Black;
            this.xuiBtnFinalizar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiBtnFinalizar.Click += new System.EventHandler(this.xuiBtnFinalizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(88, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "User:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(89, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pass:";
            // 
            // mskAdPass
            // 
            this.mskAdPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskAdPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAdPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.mskAdPass.Location = new System.Drawing.Point(133, 44);
            this.mskAdPass.Name = "mskAdPass";
            this.mskAdPass.PasswordChar = '*';
            this.mskAdPass.Size = new System.Drawing.Size(195, 24);
            this.mskAdPass.TabIndex = 1;
            // 
            // mskAdUser
            // 
            this.mskAdUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskAdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAdUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.mskAdUser.Location = new System.Drawing.Point(133, 15);
            this.mskAdUser.Name = "mskAdUser";
            this.mskAdUser.Size = new System.Drawing.Size(195, 24);
            this.mskAdUser.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(702, 324);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiBanner1);
            this.Controls.Add(this.pnlEntrar);
            this.Controls.Add(this.pnlCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlEntrar.ResumeLayout(false);
            this.pnlEntrar.PerformLayout();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBVerificado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private System.Windows.Forms.Panel panel3;
        private XanderUI.XUIButton xuiBntAdd;
        private XanderUI.XUIButton xuiBtnLogar;
        private System.Windows.Forms.MaskedTextBox mskPass;
        private System.Windows.Forms.MaskedTextBox mskUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExit;
        private XanderUI.XUIBanner xuiBanner1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlEntrar;
        private System.Windows.Forms.Panel pnlCadastro;
        private XanderUI.XUIButton xuiBntVoltar;
        private XanderUI.XUIButton xuiBtnConta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskAdEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskAdCpf;
        private XanderUI.XUIButton xuiBtnFinalizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskAdPass;
        private System.Windows.Forms.MaskedTextBox mskAdUser;
        private System.Windows.Forms.Button btnAddViewPass;
        private System.Windows.Forms.Button btnAddConfidentPass;
        private System.Windows.Forms.Button btnViewPass;
        private System.Windows.Forms.Button btnConfidentPass;
        private System.Windows.Forms.PictureBox picBVerificado;
    }
}

