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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.comboBoxPecas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxObservacoes = new System.Windows.Forms.RichTextBox();
            this.radioButtonCorretiva = new System.Windows.Forms.RadioButton();
            this.radioButtonPreventiva = new System.Windows.Forms.RadioButton();
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
            this.labelSigem = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelCardInfo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelCardInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(28, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de manutenção";
            // 
            // labelPatrimonio
            // 
            this.labelPatrimonio.AutoSize = true;
            this.labelPatrimonio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelPatrimonio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.labelPatrimonio.Location = new System.Drawing.Point(28, 100);
            this.labelPatrimonio.Name = "labelPatrimonio";
            this.labelPatrimonio.Size = new System.Drawing.Size(104, 25);
            this.labelPatrimonio.TabIndex = 31;
            this.labelPatrimonio.Text = "Patrimônio";
            // 
            // textBoxPatrimonio
            // 
            this.textBoxPatrimonio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.textBoxPatrimonio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPatrimonio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxPatrimonio.Location = new System.Drawing.Point(28, 125);
            this.textBoxPatrimonio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPatrimonio.Name = "textBoxPatrimonio";
            this.textBoxPatrimonio.Size = new System.Drawing.Size(190, 34);
            this.textBoxPatrimonio.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(28, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Local / Fabricante / Modelo";
            // 
            // buttonRead
            // 
            this.buttonRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRead.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.buttonRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRead.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.buttonRead.Location = new System.Drawing.Point(218, 125);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(90, 36);
            this.buttonRead.TabIndex = 32;
            this.buttonRead.Text = "Consultar";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // comboBoxPecas
            // 
            this.comboBoxPecas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.comboBoxPecas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPecas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxPecas.FormattingEnabled = true;
            this.comboBoxPecas.Location = new System.Drawing.Point(28, 401);
            this.comboBoxPecas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPecas.Name = "comboBoxPecas";
            this.comboBoxPecas.Size = new System.Drawing.Size(201, 36);
            this.comboBoxPecas.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(28, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Peça";
            // 
            // richTextBoxObservacoes
            // 
            this.richTextBoxObservacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.richTextBoxObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxObservacoes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.richTextBoxObservacoes.Location = new System.Drawing.Point(356, 200);
            this.richTextBoxObservacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxObservacoes.Name = "richTextBoxObservacoes";
            this.richTextBoxObservacoes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxObservacoes.Size = new System.Drawing.Size(256, 280);
            this.richTextBoxObservacoes.TabIndex = 40;
            this.richTextBoxObservacoes.Text = "";
            // 
            // radioButtonCorretiva
            // 
            this.radioButtonCorretiva.AutoSize = true;
            this.radioButtonCorretiva.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radioButtonCorretiva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.radioButtonCorretiva.Location = new System.Drawing.Point(157, 331);
            this.radioButtonCorretiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonCorretiva.Name = "radioButtonCorretiva";
            this.radioButtonCorretiva.Size = new System.Drawing.Size(110, 29);
            this.radioButtonCorretiva.TabIndex = 41;
            this.radioButtonCorretiva.TabStop = true;
            this.radioButtonCorretiva.Text = "Corretiva";
            this.radioButtonCorretiva.UseVisualStyleBackColor = true;
            // 
            // radioButtonPreventiva
            // 
            this.radioButtonPreventiva.AutoSize = true;
            this.radioButtonPreventiva.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radioButtonPreventiva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.radioButtonPreventiva.Location = new System.Drawing.Point(28, 331);
            this.radioButtonPreventiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPreventiva.Name = "radioButtonPreventiva";
            this.radioButtonPreventiva.Size = new System.Drawing.Size(121, 29);
            this.radioButtonPreventiva.TabIndex = 40;
            this.radioButtonPreventiva.TabStop = true;
            this.radioButtonPreventiva.Text = "Preventiva";
            this.radioButtonPreventiva.UseVisualStyleBackColor = true;
            // 
            // radioButtonTroca
            // 
            this.radioButtonTroca.AutoSize = true;
            this.radioButtonTroca.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radioButtonTroca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.radioButtonTroca.Location = new System.Drawing.Point(128, 478);
            this.radioButtonTroca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTroca.Name = "radioButtonTroca";
            this.radioButtonTroca.Size = new System.Drawing.Size(78, 29);
            this.radioButtonTroca.TabIndex = 39;
            this.radioButtonTroca.TabStop = true;
            this.radioButtonTroca.Text = "Troca";
            this.radioButtonTroca.UseVisualStyleBackColor = true;
            // 
            // radioButtonReparo
            // 
            this.radioButtonReparo.AutoSize = true;
            this.radioButtonReparo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radioButtonReparo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.radioButtonReparo.Location = new System.Drawing.Point(28, 478);
            this.radioButtonReparo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonReparo.Name = "radioButtonReparo";
            this.radioButtonReparo.Size = new System.Drawing.Size(92, 29);
            this.radioButtonReparo.TabIndex = 38;
            this.radioButtonReparo.TabStop = true;
            this.radioButtonReparo.Text = "Reparo";
            this.radioButtonReparo.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.buttonAdicionar.Location = new System.Drawing.Point(28, 570);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(150, 36);
            this.buttonAdicionar.TabIndex = 44;
            this.buttonAdicionar.Text = "Adicionar tarefa";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonGerar
            // 
            this.buttonGerar.AutoSize = true;
            this.buttonGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGerar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.buttonGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGerar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonGerar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.buttonGerar.Location = new System.Drawing.Point(28, 523);
            this.buttonGerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(258, 37);
            this.buttonGerar.TabIndex = 45;
            this.buttonGerar.Text = "Gerar relatório desta sessão";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.buttonFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFinalizar.FlatAppearance.BorderSize = 0;
            this.buttonFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.buttonFinalizar.Location = new System.Drawing.Point(361, 561);
            this.buttonFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(199, 36);
            this.buttonFinalizar.TabIndex = 46;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = false;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(356, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "Data da manutenção";
            // 
            // dateManutencao
            // 
            this.dateManutencao.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.dateManutencao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateManutencao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateManutencao.Location = new System.Drawing.Point(356, 125);
            this.dateManutencao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateManutencao.Name = "dateManutencao";
            this.dateManutencao.Size = new System.Drawing.Size(256, 34);
            this.dateManutencao.TabIndex = 48;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.buttonLimpar.Location = new System.Drawing.Point(361, 521);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(199, 36);
            this.buttonLimpar.TabIndex = 49;
            this.buttonLimpar.Text = "Limpar campos";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.labelLocal.Location = new System.Drawing.Point(130, 6);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(58, 25);
            this.labelLocal.TabIndex = 50;
            this.labelLocal.Text = "Local";
            this.labelLocal.Visible = false;
            // 
            // labelFabricante
            // 
            this.labelFabricante.AutoSize = true;
            this.labelFabricante.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelFabricante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.labelFabricante.Location = new System.Drawing.Point(130, 33);
            this.labelFabricante.Name = "labelFabricante";
            this.labelFabricante.Size = new System.Drawing.Size(104, 25);
            this.labelFabricante.TabIndex = 51;
            this.labelFabricante.Text = "Fabricante";
            this.labelFabricante.Visible = false;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.labelModelo.Location = new System.Drawing.Point(130, 59);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(81, 25);
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
            // labelSigem
            // 
            this.labelSigem.AutoSize = true;
            this.labelSigem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSigem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.labelSigem.Location = new System.Drawing.Point(28, 24);
            this.labelSigem.Name = "labelSigem";
            this.labelSigem.Size = new System.Drawing.Size(60, 23);
            this.labelSigem.TabIndex = 53;
            this.labelSigem.Text = "SIGEM";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.labelTitulo.Location = new System.Drawing.Point(28, 47);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(306, 37);
            this.labelTitulo.TabIndex = 54;
            this.labelTitulo.Text = "Registro de Manutenção";
            // 
            // panelCardInfo
            // 
            this.panelCardInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.panelCardInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardInfo.Controls.Add(this.label8);
            this.panelCardInfo.Controls.Add(this.label3);
            this.panelCardInfo.Controls.Add(this.label2);
            this.panelCardInfo.Controls.Add(this.labelLocal);
            this.panelCardInfo.Controls.Add(this.labelFabricante);
            this.panelCardInfo.Controls.Add(this.labelModelo);
            this.panelCardInfo.Location = new System.Drawing.Point(28, 200);
            this.panelCardInfo.Name = "panelCardInfo";
            this.panelCardInfo.Size = new System.Drawing.Size(284, 90);
            this.panelCardInfo.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(12, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "Modelo";
            this.label8.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fabricante";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Local";
            this.label2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(28, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 25);
            this.label9.TabIndex = 56;
            this.label9.Text = "Ação na peça";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(356, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 25);
            this.label10.TabIndex = 57;
            this.label10.Text = "Observações";
            // 
            // UsuarioUIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 653);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioButtonTroca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioButtonReparo);
            this.Controls.Add(this.radioButtonCorretiva);
            this.Controls.Add(this.panelCardInfo);
            this.Controls.Add(this.radioButtonPreventiva);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelSigem);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.dateManutencao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.buttonGerar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.richTextBoxObservacoes);
            this.Controls.Add(this.comboBoxPecas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.labelPatrimonio);
            this.Controls.Add(this.textBoxPatrimonio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "UsuarioUIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGEM";
            this.Load += new System.EventHandler(this.UsuarioUIL_Load);
            this.panelCardInfo.ResumeLayout(false);
            this.panelCardInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPatrimonio;
        private System.Windows.Forms.TextBox textBoxPatrimonio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ComboBox comboBoxPecas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxObservacoes;
        private System.Windows.Forms.RadioButton radioButtonCorretiva;
        private System.Windows.Forms.RadioButton radioButtonPreventiva;
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
        private System.Windows.Forms.Label labelSigem;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelCardInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}