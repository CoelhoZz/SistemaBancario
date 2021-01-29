
namespace SistemaBancario.Screens
{
    partial class Conta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conta));
            this.xuiGradientPanel1 = new XanderUI.XUIGradientPanel();
            this.txbAgencia = new System.Windows.Forms.TextBox();
            this.txbNumConta = new System.Windows.Forms.TextBox();
            this.txbBanco = new System.Windows.Forms.TextBox();
            this.xuiSbtnCancelar = new XanderUI.XUISuperButton();
            this.xuiSbtnAdicionar = new XanderUI.XUISuperButton();
            this.cbmBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.xuiGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiGradientPanel1
            // 
            this.xuiGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.xuiGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.xuiGradientPanel1.Controls.Add(this.txbAgencia);
            this.xuiGradientPanel1.Controls.Add(this.txbNumConta);
            this.xuiGradientPanel1.Controls.Add(this.txbBanco);
            this.xuiGradientPanel1.Controls.Add(this.xuiSbtnCancelar);
            this.xuiGradientPanel1.Controls.Add(this.xuiSbtnAdicionar);
            this.xuiGradientPanel1.Controls.Add(this.cbmBox);
            this.xuiGradientPanel1.Controls.Add(this.label6);
            this.xuiGradientPanel1.Controls.Add(this.label5);
            this.xuiGradientPanel1.Controls.Add(this.label4);
            this.xuiGradientPanel1.Controls.Add(this.label2);
            this.xuiGradientPanel1.Controls.Add(this.label1);
            this.xuiGradientPanel1.Controls.Add(this.label3);
            this.xuiGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xuiGradientPanel1.Name = "xuiGradientPanel1";
            this.xuiGradientPanel1.PrimerColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(95)))), ((int)(((byte)(157)))));
            this.xuiGradientPanel1.Size = new System.Drawing.Size(283, 333);
            this.xuiGradientPanel1.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.xuiGradientPanel1.TabIndex = 0;
            this.xuiGradientPanel1.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.xuiGradientPanel1.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(95)))), ((int)(((byte)(157)))));
            this.xuiGradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.xuiGradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.xuiGradientPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // txbAgencia
            // 
            this.txbAgencia.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAgencia.Location = new System.Drawing.Point(131, 225);
            this.txbAgencia.MaxLength = 4;
            this.txbAgencia.Name = "txbAgencia";
            this.txbAgencia.Size = new System.Drawing.Size(92, 27);
            this.txbAgencia.TabIndex = 4;
            this.txbAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CodigoBar);
            // 
            // txbNumConta
            // 
            this.txbNumConta.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumConta.Location = new System.Drawing.Point(131, 125);
            this.txbNumConta.MaxLength = 10;
            this.txbNumConta.Name = "txbNumConta";
            this.txbNumConta.Size = new System.Drawing.Size(135, 27);
            this.txbNumConta.TabIndex = 2;
            this.txbNumConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CodigoBar);
            // 
            // txbBanco
            // 
            this.txbBanco.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBanco.Location = new System.Drawing.Point(131, 78);
            this.txbBanco.MaxLength = 3;
            this.txbBanco.Name = "txbBanco";
            this.txbBanco.Size = new System.Drawing.Size(92, 27);
            this.txbBanco.TabIndex = 1;
            this.txbBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_CodigoBar);
            // 
            // xuiSbtnCancelar
            // 
            this.xuiSbtnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xuiSbtnCancelar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSbtnCancelar.ButtonImage")));
            this.xuiSbtnCancelar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSbtnCancelar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSbtnCancelar.ButtonText = "Cancelar";
            this.xuiSbtnCancelar.CornerRadius = 5;
            this.xuiSbtnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSbtnCancelar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSbtnCancelar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.xuiSbtnCancelar.HoverTextColor = System.Drawing.Color.DarkRed;
            this.xuiSbtnCancelar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSbtnCancelar.Location = new System.Drawing.Point(27, 269);
            this.xuiSbtnCancelar.Name = "xuiSbtnCancelar";
            this.xuiSbtnCancelar.SelectedBackColor = System.Drawing.Color.DarkRed;
            this.xuiSbtnCancelar.SelectedTextColor = System.Drawing.Color.Red;
            this.xuiSbtnCancelar.Size = new System.Drawing.Size(114, 37);
            this.xuiSbtnCancelar.SuperSelected = false;
            this.xuiSbtnCancelar.TabIndex = 6;
            this.xuiSbtnCancelar.TextColor = System.Drawing.Color.Red;
            this.xuiSbtnCancelar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSbtnCancelar.Click += new System.EventHandler(this.xuiBtnCancelar_Click);
            // 
            // xuiSbtnAdicionar
            // 
            this.xuiSbtnAdicionar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiSbtnAdicionar.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSbtnAdicionar.ButtonImage")));
            this.xuiSbtnAdicionar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSbtnAdicionar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSbtnAdicionar.ButtonText = "Adicionar";
            this.xuiSbtnAdicionar.CornerRadius = 5;
            this.xuiSbtnAdicionar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSbtnAdicionar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSbtnAdicionar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSbtnAdicionar.HoverTextColor = System.Drawing.Color.White;
            this.xuiSbtnAdicionar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSbtnAdicionar.Location = new System.Drawing.Point(147, 269);
            this.xuiSbtnAdicionar.Name = "xuiSbtnAdicionar";
            this.xuiSbtnAdicionar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSbtnAdicionar.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSbtnAdicionar.Size = new System.Drawing.Size(114, 37);
            this.xuiSbtnAdicionar.SuperSelected = false;
            this.xuiSbtnAdicionar.TabIndex = 5;
            this.xuiSbtnAdicionar.TextColor = System.Drawing.Color.White;
            this.xuiSbtnAdicionar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSbtnAdicionar.Click += new System.EventHandler(this.xuiSbtnAdicionar_Click);
            // 
            // cbmBox
            // 
            this.cbmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmBox.FormattingEnabled = true;
            this.cbmBox.Items.AddRange(new object[] {
            "Conta Corrente",
            "Conta Poupança",
            "Conta Salario"});
            this.cbmBox.Location = new System.Drawing.Point(131, 174);
            this.cbmBox.Name = "cbmBox";
            this.cbmBox.Size = new System.Drawing.Size(135, 29);
            this.cbmBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(28, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tip. Conta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(47, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "com o digito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(45, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Agencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Num. Conta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(61, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Banco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sistema Bancario";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 15;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(95)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(283, 331);
            this.Controls.Add(this.xuiGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta";
            this.xuiGradientPanel1.ResumeLayout(false);
            this.xuiGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGradientPanel xuiGradientPanel1;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private XanderUI.XUISuperButton xuiSbtnCancelar;
        private XanderUI.XUISuperButton xuiSbtnAdicionar;
        private System.Windows.Forms.TextBox txbBanco;
        private System.Windows.Forms.TextBox txbAgencia;
        private System.Windows.Forms.TextBox txbNumConta;
    }
}