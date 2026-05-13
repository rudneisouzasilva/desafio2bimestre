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
            this.listBoxPecas = new System.Windows.Forms.ListBox();
            this.buttonNovaPeca = new System.Windows.Forms.Button();
            this.textBoxNovaPeca = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPecas
            // 
            this.listBoxPecas.FormattingEnabled = true;
            this.listBoxPecas.ItemHeight = 20;
            this.listBoxPecas.Location = new System.Drawing.Point(1, 0);
            this.listBoxPecas.Name = "listBoxPecas";
            this.listBoxPecas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxPecas.Size = new System.Drawing.Size(485, 404);
            this.listBoxPecas.TabIndex = 0;
            // 
            // buttonNovaPeca
            // 
            this.buttonNovaPeca.Location = new System.Drawing.Point(140, 474);
            this.buttonNovaPeca.Name = "buttonNovaPeca";
            this.buttonNovaPeca.Size = new System.Drawing.Size(211, 45);
            this.buttonNovaPeca.TabIndex = 1;
            this.buttonNovaPeca.Text = "Adicionar nova peça";
            this.buttonNovaPeca.UseVisualStyleBackColor = true;
            this.buttonNovaPeca.Click += new System.EventHandler(this.buttonNovaPeca_Click);
            // 
            // textBoxNovaPeca
            // 
            this.textBoxNovaPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNovaPeca.Location = new System.Drawing.Point(140, 433);
            this.textBoxNovaPeca.Name = "textBoxNovaPeca";
            this.textBoxNovaPeca.Size = new System.Drawing.Size(211, 35);
            this.textBoxNovaPeca.TabIndex = 2;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(286, 593);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(150, 47);
            this.buttonConfirmar.TabIndex = 3;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(71, 593);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(150, 47);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // PecasUIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 664);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxNovaPeca);
            this.Controls.Add(this.buttonNovaPeca);
            this.Controls.Add(this.listBoxPecas);
            this.Name = "PecasUIL";
            this.Text = "Pecas";
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
    }
}