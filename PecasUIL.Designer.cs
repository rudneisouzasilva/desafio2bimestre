namespace Desafio_AD_BD
{
    partial class PecasUIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PecasUIL));
            this.listBoxPecas = new System.Windows.Forms.ListBox();
            this.buttonNovaPeca = new System.Windows.Forms.Button();
            this.textBoxNovaPeca = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPecas
            // 
            this.listBoxPecas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPecas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxPecas.FormattingEnabled = true;
            this.listBoxPecas.ItemHeight = 17;
            this.listBoxPecas.Location = new System.Drawing.Point(18, 81);
            this.listBoxPecas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPecas.Name = "listBoxPecas";
            this.listBoxPecas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxPecas.Size = new System.Drawing.Size(244, 189);
            this.listBoxPecas.TabIndex = 0;
            // 
            // buttonNovaPeca
            // 
            this.buttonNovaPeca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.buttonNovaPeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNovaPeca.FlatAppearance.BorderSize = 0;
            this.buttonNovaPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovaPeca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonNovaPeca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.buttonNovaPeca.Location = new System.Drawing.Point(171, 278);
            this.buttonNovaPeca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNovaPeca.Name = "buttonNovaPeca";
            this.buttonNovaPeca.Size = new System.Drawing.Size(90, 29);
            this.buttonNovaPeca.TabIndex = 1;
            this.buttonNovaPeca.Text = "Adicionar";
            this.buttonNovaPeca.UseVisualStyleBackColor = false;
            this.buttonNovaPeca.Click += new System.EventHandler(this.buttonNovaPeca_Click);
            // 
            // textBoxNovaPeca
            // 
            this.textBoxNovaPeca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNovaPeca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxNovaPeca.Location = new System.Drawing.Point(18, 278);
            this.textBoxNovaPeca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNovaPeca.Name = "textBoxNovaPeca";
            this.textBoxNovaPeca.Size = new System.Drawing.Size(148, 29);
            this.textBoxNovaPeca.TabIndex = 2;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.buttonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmar.FlatAppearance.BorderSize = 0;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.buttonConfirmar.Location = new System.Drawing.Point(142, 314);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(118, 29);
            this.buttonConfirmar.TabIndex = 3;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.buttonCancelar.Location = new System.Drawing.Point(18, 314);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(118, 29);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "SIGEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gerenciar peças";
            // 
            // PecasUIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(283, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxNovaPeca);
            this.Controls.Add(this.buttonNovaPeca);
            this.Controls.Add(this.listBoxPecas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "PecasUIL";
            this.Text = "SIGEM";
            this.Load += new System.EventHandler(this.PecasUIL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPecas;
        private System.Windows.Forms.Button buttonNovaPeca;
        private System.Windows.Forms.TextBox textBoxNovaPeca;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}