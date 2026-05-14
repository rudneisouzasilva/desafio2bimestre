namespace Desafio_AD_BD
{
    partial class UsuarioUIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioUIL));
            this.label1 = new System.Windows.Forms.Label();
            this.labelPatrimonio = new System.Windows.Forms.Label();
            this.textBoxPatrimonio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.comboBoxPecas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxObservacoes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxManutencao = new System.Windows.Forms.GroupBox();
            this.radioButtonCorretiva = new System.Windows.Forms.RadioButton();
            this.radioButtonPreventiva = new System.Windows.Forms.RadioButton();
            this.groupBoxPeca = new System.Windows.Forms.GroupBox();
            this.radioButtonTroca = new System.Windows.Forms.RadioButton();
            this.radioButtonReparo = new System.Windows.Forms.RadioButton();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonGerar = new System.Windows.Forms.Button();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateManutencao = new System.Windows.Forms.DateTimePicker();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelFabricante = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.relatorioGerado = new System.Drawing.Printing.PrintDocument();
            this.previsualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBoxManutencao.SuspendLayout();
            this.groupBoxPeca.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de manutenção";
            // 
            // labelPatrimonio
            // 
            this.labelPatrimonio.AutoSize = true;
            this.labelPatrimonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatrimonio.Location = new System.Drawing.Point(39, 46);
            this.labelPatrimonio.Name = "labelPatrimonio";
            this.labelPatrimonio.Size = new System.Drawing.Size(129, 29);
            this.labelPatrimonio.TabIndex = 31;
            this.labelPatrimonio.Text = "Patrimônio";
            // 
            // textBoxPatrimonio
            // 
            this.textBoxPatrimonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatrimonio.Location = new System.Drawing.Point(296, 43);
            this.textBoxPatrimonio.Name = "textBoxPatrimonio";
            this.textBoxPatrimonio.Size = new System.Drawing.Size(226, 35);
            this.textBoxPatrimonio.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fabricante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Local:";
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(550, 38);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(133, 45);
            this.buttonRead.TabIndex = 32;
            this.buttonRead.Text = "Consultar";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // comboBoxPecas
            // 
            this.comboBoxPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPecas.FormattingEnabled = true;
            this.comboBoxPecas.Location = new System.Drawing.Point(296, 322);
            this.comboBoxPecas.Name = "comboBoxPecas";
            this.comboBoxPecas.Size = new System.Drawing.Size(226, 37);
            this.comboBoxPecas.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "Peça";
            // 
            // richTextBoxObservacoes
            // 
            this.richTextBoxObservacoes.Location = new System.Drawing.Point(585, 183);
            this.richTextBoxObservacoes.Name = "richTextBoxObservacoes";
            this.richTextBoxObservacoes.Size = new System.Drawing.Size(596, 122);
            this.richTextBoxObservacoes.TabIndex = 40;
            this.richTextBoxObservacoes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Observações";
            // 
            // groupBoxManutencao
            // 
            this.groupBoxManutencao.Controls.Add(this.radioButtonCorretiva);
            this.groupBoxManutencao.Controls.Add(this.radioButtonPreventiva);
            this.groupBoxManutencao.Location = new System.Drawing.Point(279, 100);
            this.groupBoxManutencao.Name = "groupBoxManutencao";
            this.groupBoxManutencao.Size = new System.Drawing.Size(243, 58);
            this.groupBoxManutencao.TabIndex = 42;
            this.groupBoxManutencao.TabStop = false;
            // 
            // radioButtonCorretiva
            // 
            this.radioButtonCorretiva.AutoSize = true;
            this.radioButtonCorretiva.Location = new System.Drawing.Point(146, 20);
            this.radioButtonCorretiva.Name = "radioButtonCorretiva";
            this.radioButtonCorretiva.Size = new System.Drawing.Size(97, 24);
            this.radioButtonCorretiva.TabIndex = 41;
            this.radioButtonCorretiva.TabStop = true;
            this.radioButtonCorretiva.Text = "Corretiva";
            this.radioButtonCorretiva.UseVisualStyleBackColor = true;
            // 
            // radioButtonPreventiva
            // 
            this.radioButtonPreventiva.AutoSize = true;
            this.radioButtonPreventiva.Location = new System.Drawing.Point(17, 20);
            this.radioButtonPreventiva.Name = "radioButtonPreventiva";
            this.radioButtonPreventiva.Size = new System.Drawing.Size(107, 24);
            this.radioButtonPreventiva.TabIndex = 40;
            this.radioButtonPreventiva.TabStop = true;
            this.radioButtonPreventiva.Text = "Preventiva";
            this.radioButtonPreventiva.UseVisualStyleBackColor = true;
            // 
            // groupBoxPeca
            // 
            this.groupBoxPeca.Controls.Add(this.radioButtonTroca);
            this.groupBoxPeca.Controls.Add(this.radioButtonReparo);
            this.groupBoxPeca.Location = new System.Drawing.Point(585, 311);
            this.groupBoxPeca.Name = "groupBoxPeca";
            this.groupBoxPeca.Size = new System.Drawing.Size(200, 58);
            this.groupBoxPeca.TabIndex = 43;
            this.groupBoxPeca.TabStop = false;
            // 
            // radioButtonTroca
            // 
            this.radioButtonTroca.AutoSize = true;
            this.radioButtonTroca.Location = new System.Drawing.Point(115, 17);
            this.radioButtonTroca.Name = "radioButtonTroca";
            this.radioButtonTroca.Size = new System.Drawing.Size(74, 24);
            this.radioButtonTroca.TabIndex = 39;
            this.radioButtonTroca.TabStop = true;
            this.radioButtonTroca.Text = "Troca";
            this.radioButtonTroca.UseVisualStyleBackColor = true;
            // 
            // radioButtonReparo
            // 
            this.radioButtonReparo.AutoSize = true;
            this.radioButtonReparo.Location = new System.Drawing.Point(11, 17);
            this.radioButtonReparo.Name = "radioButtonReparo";
            this.radioButtonReparo.Size = new System.Drawing.Size(87, 24);
            this.radioButtonReparo.TabIndex = 38;
            this.radioButtonReparo.TabStop = true;
            this.radioButtonReparo.Text = "Reparo";
            this.radioButtonReparo.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(656, 432);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(224, 45);
            this.buttonAdicionar.TabIndex = 44;
            this.buttonAdicionar.Text = "Adicionar tarefa";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonGerar
            // 
            this.buttonGerar.Location = new System.Drawing.Point(394, 432);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(224, 45);
            this.buttonGerar.TabIndex = 45;
            this.buttonGerar.Text = "Gerar relatório desta sessão";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonFinalizar.Location = new System.Drawing.Point(518, 588);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(224, 45);
            this.buttonFinalizar.TabIndex = 46;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = false;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(580, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 29);
            this.label7.TabIndex = 47;
            this.label7.Text = "Data da manutenção";
            // 
            // dateManutencao
            // 
            this.dateManutencao.Location = new System.Drawing.Point(818, 115);
            this.dateManutencao.Name = "dateManutencao";
            this.dateManutencao.Size = new System.Drawing.Size(363, 26);
            this.dateManutencao.TabIndex = 48;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(518, 520);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(224, 45);
            this.buttonLimpar.TabIndex = 49;
            this.buttonLimpar.Text = "Limpar campos";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocal.Location = new System.Drawing.Point(291, 161);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(71, 29);
            this.labelLocal.TabIndex = 50;
            this.labelLocal.Text = "Local";
            this.labelLocal.Visible = false;
            // 
            // labelFabricante
            // 
            this.labelFabricante.AutoSize = true;
            this.labelFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFabricante.Location = new System.Drawing.Point(291, 214);
            this.labelFabricante.Name = "labelFabricante";
            this.labelFabricante.Size = new System.Drawing.Size(127, 29);
            this.labelFabricante.TabIndex = 51;
            this.labelFabricante.Text = "Fabricante";
            this.labelFabricante.Visible = false;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(291, 269);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(95, 29);
            this.labelModelo.TabIndex = 52;
            this.labelModelo.Text = "Modelo";
            this.labelModelo.Visible = false;
            // 
            // relatorioGerado
            // 
            this.relatorioGerado.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.relatorio_PrintPage);
            // 
            // previsualizacao
            // 
            this.previsualizacao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.previsualizacao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.previsualizacao.ClientSize = new System.Drawing.Size(400, 300);
            this.previsualizacao.Document = this.relatorioGerado;
            this.previsualizacao.Enabled = true;
            this.previsualizacao.Icon = ((System.Drawing.Icon)(resources.GetObject("previsualizacao.Icon")));
            this.previsualizacao.Name = "printPreviewDialog1";
            this.previsualizacao.Visible = false;
            // 
            // UsuarioUIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 673);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelFabricante);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.dateManutencao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.buttonGerar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.groupBoxPeca);
            this.Controls.Add(this.groupBoxManutencao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxObservacoes);
            this.Controls.Add(this.comboBoxPecas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.labelPatrimonio);
            this.Controls.Add(this.textBoxPatrimonio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuarioUIL";
            this.Text = "UsuarioUIL";
            this.Load += new System.EventHandler(this.UsuarioUIL_Load);
            this.groupBoxManutencao.ResumeLayout(false);
            this.groupBoxManutencao.PerformLayout();
            this.groupBoxPeca.ResumeLayout(false);
            this.groupBoxPeca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPatrimonio;
        private System.Windows.Forms.TextBox textBoxPatrimonio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ComboBox comboBoxPecas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxObservacoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxManutencao;
        private System.Windows.Forms.RadioButton radioButtonCorretiva;
        private System.Windows.Forms.RadioButton radioButtonPreventiva;
        private System.Windows.Forms.GroupBox groupBoxPeca;
        private System.Windows.Forms.RadioButton radioButtonTroca;
        private System.Windows.Forms.RadioButton radioButtonReparo;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateManutencao;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelFabricante;
        private System.Windows.Forms.Label labelModelo;
        private System.Drawing.Printing.PrintDocument relatorioGerado;
        private System.Windows.Forms.PrintPreviewDialog previsualizacao;
    }
}