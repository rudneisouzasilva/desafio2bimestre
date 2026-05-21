using ClassErro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Drawing;


namespace Desafio_AD_BD
{
    public partial class AdministradorUIL : Form
    {
        private List<string> pecasSelecionadas = new List<string>();

        public AdministradorUIL()
        {
            InitializeComponent();
            Estilizar();
        }

        private void Estilizar()
        {
            // Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.Text = "SIGEM - Administrador";

            // TabControl e TabPages
            tabControl1.Font = new Font("Segoe UI", 11);
            tabPage1.Text = "Cadastro de equipamentos";
            tabPage2.Text = "Consulta de manutenções";

            // Componentes do tabPage1
            comboBoxLocal.Size =  comboBoxFabricante.Size = comboBoxModelo.Size = new Size(240, 36);
            comboBoxLocal.Font = comboBoxFabricante.Font = comboBoxModelo.Font = new Font("Segoe UI", 12);
            comboBoxLocal.BackColor = comboBoxFabricante.BackColor = comboBoxModelo.BackColor = ColorTranslator.FromHtml("#F1EFE8");
            comboBoxLocal.DropDownStyle = comboBoxFabricante.DropDownStyle = comboBoxModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocal.FlatStyle = comboBoxFabricante.FlatStyle = comboBoxModelo.FlatStyle = FlatStyle.Flat;
            textBoxPatrimonio.Size = new Size(240, 36);
            textBoxPatrimonio.Font = new Font("Segoe UI", 12);
            textBoxPatrimonio.BackColor = ColorTranslator.FromHtml("#F1EFE8");
            textBoxPatrimonio.BorderStyle = BorderStyle.FixedSingle;
            buttonAdicionar.Size = new Size(240, 36);
            buttonAdicionar.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            buttonAdicionar.ForeColor = ColorTranslator.FromHtml("#2C2C2A");
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.FlatAppearance.BorderSize = 1;
            buttonAdicionar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#B4B2A9");
            buttonAdicionar.Font = new Font("Segoe UI", 11);
            buttonConsultar.Size = buttonAtualizar.Size = buttonExcluir.Size = buttonInserir.Size = new Size(116, 36);
            buttonConsultar.Font = buttonAtualizar.Font = buttonExcluir.Font = buttonInserir.Font = new Font("Segoe UI", 11);
            buttonConsultar.FlatStyle = buttonAtualizar.FlatStyle = buttonExcluir.FlatStyle = buttonInserir.FlatStyle = FlatStyle.Flat;
            buttonConsultar.FlatAppearance.BorderColor = buttonAtualizar.FlatAppearance.BorderColor = buttonInserir.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#B4B2A9");
            buttonConsultar.ForeColor = buttonAtualizar.ForeColor = ColorTranslator.FromHtml("#2C2C2A");
            buttonInserir.BackColor = ColorTranslator.FromHtml("#1A1A18");
            buttonInserir.ForeColor = ColorTranslator.FromHtml("#F1EFE8");
            buttonInserir.FlatAppearance.BorderSize = 0;
            buttonExcluir.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#A32D2D");
            buttonExcluir.ForeColor = ColorTranslator.FromHtml("#A32D2D");
            buttonLimpar.Size = buttonFinalizar.Size = new Size(116, 36);
            buttonLimpar.Font = buttonFinalizar.Font = new Font("Segoe UI", 11);
            buttonLimpar.FlatStyle = buttonFinalizar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.FlatAppearance.BorderColor = buttonFinalizar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#B4B2A9");
            buttonLimpar.ForeColor = buttonFinalizar.ForeColor = ColorTranslator.FromHtml("#888780");
            buttonLimpar.BackColor = buttonFinalizar.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        //Evento de carregamento da tela, chama os métodos para carregar os combos e limpar os campos
        private void AdministradorUIL_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            LimparCampos();
            buttonInserir.Top = buttonConsultar.Top = buttonAdicionar.Bottom + 16;
            buttonConsultar.Left = buttonInserir.Right + 8;
            buttonAtualizar.Top = buttonExcluir.Top = buttonInserir.Bottom + 16;
            buttonExcluir.Left = buttonAtualizar.Right + 8;
            buttonLimpar.Top = buttonFinalizar.Top = buttonAtualizar.Bottom + 8;
            buttonLimpar.Left = buttonInserir.Left;
            buttonFinalizar.Left = buttonLimpar.Right + 8;
        }

        //Evento de mudança de seleção do comboBoxLocal, exibe ou oculta os campos para inserir um novo local dependendo se a opção "Outros" foi selecionada ou não
        private void comboBoxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool outros = comboBoxLocal.Text == "Outros";

            labelNovoLocal.Visible = outros;
            textBoxLocais.Visible = outros;
        }

        //Evento de mudança de seleção do comboBoxFabricante, exibe ou oculta os campos para inserir um novo fabricante e modelo dependendo se a opção "Outros" foi selecionada ou não, além de habilitar ou desabilitar o comboBoxModelo
        private void comboBoxFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool outros = comboBoxFabricante.Text == "Outros";

            comboBoxModelo.Enabled = !outros;

            labelNovoFabricante.Visible = outros;
            textBoxFabricantes.Visible = outros;

            labelNovoModelo.Visible = outros;
            textBoxModelos.Visible = outros;
        }

        //Evento de mudança de seleção do comboBoxModelo, exibe ou oculta os campos para inserir um novo modelo dependendo se a opção "Outros" foi selecionada ou se o comboBoxFabricante estiver com a opção "Outros" selecionada
        private void comboBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFabricante.Text == "Outros")
                return;

            bool outros = comboBoxModelo.Text == "Outros";

            labelNovoModelo.Visible = outros;
            textBoxModelos.Visible = outros;
        }

        //Evento de clique do botão Limpar, chama o método para limpar os campos da tela
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //Metodo para montar um objeto do tipo Equipamentos com os dados preenchidos na tela, verificando se as opções "Outros" foram selecionadas para os combos de Local, Fabricante e Modelo, caso contrário utilizando os valores selecionados nos combos
        private Equipamentos MontarEquipamentoDaTela()
        {
            Equipamentos equipamentos = new Equipamentos();

            equipamentos.Local = comboBoxLocal.Text == "Outros"
                ? textBoxLocais.Text.Trim()
                : comboBoxLocal.Text.Trim();

            equipamentos.Fabricante = comboBoxFabricante.Text == "Outros"
                ? textBoxFabricantes.Text.Trim()
                : comboBoxFabricante.Text.Trim();

            equipamentos.Modelo = comboBoxModelo.Text == "Outros" || comboBoxFabricante.Text == "Outros"
                ? textBoxModelos.Text.Trim()
                : comboBoxModelo.Text.Trim();

            equipamentos.Patrimonio = textBoxPatrimonio.Text.Trim();

            equipamentos.Pecas = new List<string>(pecasSelecionadas);

            return equipamentos;
        }

        //Evento de clique do botão Inserir, chama o método para montar um objeto do tipo Equipamentos com os dados preenchidos na tela e depois chama o método para cadastrar o equipamento no banco, caso ocorra algum erro durante o processo exibe uma mensagem de erro, caso contrário exibe uma mensagem de sucesso, limpa os campos da tela e recarrega os combos
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            EquipamentoBLL equipamentoBLL = new EquipamentoBLL();

            Equipamentos equipamentos = MontarEquipamentoDaTela();

            equipamentoBLL.CadastrarEquipamento(equipamentos);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                return;
            }

            MessageBox.Show("Equipamento cadastrado com sucesso!");

            LimparCampos();
            CarregarCombos();
        }

        //Metodo para limpar os campos da tela e resetar os combos
        public void LimparCampos()
        {
            comboBoxLocal.SelectedIndex = -1;
            comboBoxFabricante.SelectedIndex = -1;
            comboBoxModelo.SelectedIndex = -1;

            textBoxPatrimonio.Clear();
            textBoxLocais.Clear();
            textBoxFabricantes.Clear();
            textBoxModelos.Clear();
            listBoxPecasVisualizacao.Items.Clear();

            pecasSelecionadas.Clear();

            textBoxLocais.Visible = false;
            textBoxFabricantes.Visible = false;
            textBoxModelos.Visible = false;
            listBoxPecasVisualizacao.Visible = false;

            labelNovoLocal.Visible = false;
            labelNovoFabricante.Visible = false;
            labelNovoModelo.Visible = false;
            labelPecas.Visible = false;

            comboBoxModelo.Enabled = true;
        }

        //Metodo para carregar os combos de Local, Fabricante e Modelo com os dados do banco, adicionando a opção "Outros" no final de cada combo
        private void CarregarCombos()
        {
            // ================= LOCAL =================

            DataTable dtLocal =
                EquipamentoDAL.ListarDistinct("Local");

            DataRow rowLocal = dtLocal.NewRow();
            rowLocal["Local"] = "Outros";
            dtLocal.Rows.Add(rowLocal);

            comboBoxLocal.DataSource = dtLocal;
            comboBoxLocal.DisplayMember = "Local";
            comboBoxLocal.ValueMember = "Local";
            comboBoxLocal.SelectedIndex = -1;

            // ================= FABRICANTE =================

            DataTable dtFabricante =
                EquipamentoDAL.ListarDistinct("Fabricante");

            DataRow rowFabricante = dtFabricante.NewRow();
            rowFabricante["Fabricante"] = "Outros";
            dtFabricante.Rows.Add(rowFabricante);

            comboBoxFabricante.DataSource = dtFabricante;
            comboBoxFabricante.DisplayMember = "Fabricante";
            comboBoxFabricante.ValueMember = "Fabricante";
            comboBoxFabricante.SelectedIndex = -1;

            // ================= MODELO =================

            DataTable dtModelo =
                EquipamentoDAL.ListarDistinct("Modelo");

            DataRow rowModelo = dtModelo.NewRow();
            rowModelo["Modelo"] = "Outros";
            dtModelo.Rows.Add(rowModelo);

            comboBoxModelo.DataSource = dtModelo;
            comboBoxModelo.DisplayMember = "Modelo";
            comboBoxModelo.ValueMember = "Modelo";
            comboBoxModelo.SelectedIndex = -1;
        }

        //Metodo para abrir a tela de seleção de peças e atualizar a lista de peças selecionadas na tela principal
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            PecasUIL tela = new PecasUIL(pecasSelecionadas);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                pecasSelecionadas = tela.PecasSelecionadas;

                labelPecas.Visible = true;
                listBoxPecasVisualizacao.Items.Clear();
                //textBoxPecas.Visible = true;
                //textBoxPecas.Text = string.Join(", ", pecasSelecionadas);
                listBoxPecasVisualizacao.Visible = true;
                foreach (var peca in pecasSelecionadas)
                {
                    listBoxPecasVisualizacao.Items.Add(peca);
                }

                MessageBox.Show("Peças selecionadas: " + string.Join(", ", pecasSelecionadas));
            }
        }

        //Metodo para consultar um equipamento pelo patrimônio e preencher os campos da tela com os dados do equipamento encontrado, caso contrário exibir uma mensagem de erro
        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            EquipamentoBLL equipamentoBLL = new EquipamentoBLL();

            Equipamentos equipamentos = new Equipamentos();
            equipamentos.Patrimonio = textBoxPatrimonio.Text.Trim();

            DataTable resultado = equipamentoBLL.ConsultarEquipamento(equipamentos);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                return;
            }

            if (resultado == null || resultado.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum equipamento encontrado.");
                return;
            }

            DataRow row = resultado.Rows[0];

            textBoxLocais.Visible = true;
            textBoxFabricantes.Visible = true;
            textBoxModelos.Visible = true;
            labelPecas.Visible = true;
            listBoxPecasVisualizacao.Visible = true;

            textBoxLocais.Text = row["Local"].ToString();
            textBoxFabricantes.Text = row["Fabricante"].ToString();
            textBoxModelos.Text = row["Modelo"].ToString();
            listBoxPecasVisualizacao.Items.Clear();
            pecasSelecionadas.Clear();

            string pecasTexto = row["Pecas"].ToString();

            if (!string.IsNullOrWhiteSpace(pecasTexto))
            {
                string[] pecas = pecasTexto.Split(',');

                foreach (string peca in pecas)
                {
                    string nomePeca = peca.Trim();

                    if (nomePeca != "" && !pecasSelecionadas.Contains(nomePeca))
                    {
                        pecasSelecionadas.Add(nomePeca);
                        listBoxPecasVisualizacao.Items.Add(nomePeca);
                    }
                }
            }
        }

        //Metodo para atualizar um equipamento com base nos dados preenchidos na tela, caso o patrimônio informado exista no banco, caso contrário exibir uma mensagem de erro
        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            EquipamentoBLL equipamentoBLL = new EquipamentoBLL();

            Equipamentos equipamentos = MontarEquipamentoDaTela();

            equipamentoBLL.AtualizarEquipamento(equipamentos);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                return;
            }

            MessageBox.Show("Equipamento atualizado com sucesso!");

            LimparCampos();
            CarregarCombos();
        }

        //Metodo para excluir um equipamento com base no patrimônio informado, caso o patrimônio exista no banco, caso contrário exibir uma mensagem de erro, antes de excluir exibir uma mensagem de confirmação para o usuário
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            EquipamentoBLL equipamentoBLL = new EquipamentoBLL();

            Equipamentos equipamentos = new Equipamentos();
            equipamentos.Patrimonio = textBoxPatrimonio.Text.Trim();

            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja excluir este equipamento?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resposta == DialogResult.No)
                return;

            equipamentoBLL.ExcluirEquipamento(equipamentos);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                return;
            }

            MessageBox.Show("Equipamento excluído com sucesso!");

            LimparCampos();
            CarregarCombos();
        }

        //Metodo para finalizar o programa, antes de finalizar exibir uma mensagem de confirmação para o usuário
        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja sair?",
                "Confirmar saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Metodo para consultar as manutenções de um equipamento com base no patrimônio e no intervalo de datas informado, caso o patrimônio seja vazio ou o intervalo de datas seja inválido exibir uma mensagem de erro, caso contrário exibir os resultados em um DataGridView
        private void buttonConsultarManutencoes_Click(object sender, EventArgs e)
        {
            TarefaBLL bll = new TarefaBLL();

            string patrimonio = textBoxPatrimonio2.Text.Trim();
            DateTime dataInicio = dateTimePickerInicio.Value;
            DateTime dataFim = dateTimePickerFim.Value;

            DataTable resultado = bll.ConsultarManutencoes(
                patrimonio,
                dataInicio,
                dataFim
            );

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                return;
            }

            if (resultado == null || resultado.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma manutenção encontrada.");
                dataGridViewManutencoes.DataSource = null;
                return;
            }

            dataGridViewManutencoes.DataSource = resultado;
        }

        private void textBoxLocais_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFabricantes_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxModelos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}