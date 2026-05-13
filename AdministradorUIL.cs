using ClassErro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Desafio_AD_BD
{
    public partial class AdministradorUIL : Form
    {
        private List<string> pecasSelecionadas = new List<string>();

        public AdministradorUIL()
        {
            InitializeComponent();
        }

        private void AdministradorUIL_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            LimparCampos();
        }

        private void comboBoxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool outros = comboBoxLocal.Text == "Outros";

            labelNovoLocal.Visible = outros;
            textBoxLocais.Visible = outros;
        }

        private void comboBoxFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool outros = comboBoxFabricante.Text == "Outros";

            comboBoxModelo.Enabled = !outros;

            labelNovoFabricante.Visible = outros;
            textBoxFabricantes.Visible = outros;

            labelNovoModelo.Visible = outros;
            textBoxModelos.Visible = outros;
        }

        private void comboBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFabricante.Text == "Outros")
                return;

            bool outros = comboBoxModelo.Text == "Outros";

            labelNovoModelo.Visible = outros;
            textBoxModelos.Visible = outros;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

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

        public void LimparCampos()
        {
            comboBoxLocal.SelectedIndex = -1;
            comboBoxFabricante.SelectedIndex = -1;
            comboBoxModelo.SelectedIndex = -1;

            textBoxPatrimonio.Clear();
            textBoxLocais.Clear();
            textBoxFabricantes.Clear();
            textBoxModelos.Clear();
            textBoxPecas.Clear();

            pecasSelecionadas.Clear();

            textBoxLocais.Visible = false;
            textBoxFabricantes.Visible = false;
            textBoxModelos.Visible = false;
            textBoxPecas.Visible = false;

            labelNovoLocal.Visible = false;
            labelNovoFabricante.Visible = false;
            labelNovoModelo.Visible = false;
            labelPecas.Visible = false;

            comboBoxModelo.Enabled = true;
        }

        private void CarregarCombos()
        {
            CarregarCombo(comboBoxLocal, EquipamentoDAL.ListarDistinct("Local"), "Local");
            CarregarCombo(comboBoxFabricante, EquipamentoDAL.ListarDistinct("Fabricante"), "Fabricante");
            CarregarCombo(comboBoxModelo, EquipamentoDAL.ListarDistinct("Modelo"), "Modelo");
        }

        private void CarregarCombo(ComboBox combo, DataTable dt, string coluna)
        {
            DataRow row = dt.NewRow();
            row[coluna] = "Outros";
            dt.Rows.Add(row);

            combo.DataSource = dt;
            combo.DisplayMember = coluna;
            combo.ValueMember = coluna;
            combo.SelectedIndex = -1;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            PecasUIL tela = new PecasUIL();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                pecasSelecionadas = tela.PecasSelecionadas;

                labelPecas.Visible = true;
                textBoxPecas.Visible = true;
                textBoxPecas.Text = string.Join(", ", pecasSelecionadas);

                MessageBox.Show("Peças selecionadas: " + string.Join(", ", pecasSelecionadas));
            }
        }

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
            textBoxPecas.Visible = true;

            textBoxLocais.Text = row["Local"].ToString();
            textBoxFabricantes.Text = row["Fabricante"].ToString();
            textBoxModelos.Text = row["Modelo"].ToString();
            textBoxPecas.Text = row["Pecas"].ToString();
        }

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
    }
}