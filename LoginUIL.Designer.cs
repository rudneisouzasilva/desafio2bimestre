namespace Desafio_AD_BD
{
    partial class LoginUIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUIL));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.linkLabelInscrever = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelMostrar = new System.Windows.Forms.LinkLabel();
            this.labelSigem = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(45, 133);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(264, 30);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(39, 206);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(214, 30);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.Location = new System.Drawing.Point(39, 285);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(135, 56);
            this.buttonEntrar.TabIndex = 2;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.labelUsuario.Location = new System.Drawing.Point(32, 94);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(77, 25);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "Usuário";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(40, 166);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(70, 25);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "Senha";
            // 
            // linkLabelInscrever
            // 
            this.linkLabelInscrever.AutoSize = true;
            this.linkLabelInscrever.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelInscrever.Location = new System.Drawing.Point(35, 364);
            this.linkLabelInscrever.Name = "linkLabelInscrever";
            this.linkLabelInscrever.Size = new System.Drawing.Size(96, 20);
            this.linkLabelInscrever.TabIndex = 6;
            this.linkLabelInscrever.TabStop = true;
            this.linkLabelInscrever.Text = "Inscreva-se";
            this.linkLabelInscrever.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInscrever_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 7;
            // 
            // linkLabelMostrar
            // 
            this.linkLabelMostrar.AutoSize = true;
            this.linkLabelMostrar.LinkColor = System.Drawing.Color.Black;
            this.linkLabelMostrar.Location = new System.Drawing.Point(41, 257);
            this.linkLabelMostrar.Name = "linkLabelMostrar";
            this.linkLabelMostrar.Size = new System.Drawing.Size(119, 23);
            this.linkLabelMostrar.TabIndex = 8;
            this.linkLabelMostrar.TabStop = true;
            this.linkLabelMostrar.Text = "Mostrar senha";
            this.linkLabelMostrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMostrar_LinkClicked);
            // 
            // labelSigem
            // 
            this.labelSigem.AutoSize = true;
            this.labelSigem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.labelSigem.Location = new System.Drawing.Point(32, 28);
            this.labelSigem.Name = "labelSigem";
            this.labelSigem.Size = new System.Drawing.Size(60, 23);
            this.labelSigem.TabIndex = 9;
            this.labelSigem.Text = "SIGEM";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.labelTitulo.Location = new System.Drawing.Point(32, 46);
            this.labelTitulo.MaximumSize = new System.Drawing.Size(264, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(252, 111);
            this.labelTitulo.TabIndex = 10;
            this.labelTitulo.Text = "Sistema de Gestão de Equipamentos e Manutenção";
            // 
            // LoginUIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 413);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelSigem);
            this.Controls.Add(this.linkLabelMostrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelInscrever);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginUIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGEM";
            this.Load += new System.EventHandler(this.LoginUIL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.LinkLabel linkLabelInscrever;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelMostrar;
        private System.Windows.Forms.Label labelSigem;
        private System.Windows.Forms.Label labelTitulo;
    }
}

