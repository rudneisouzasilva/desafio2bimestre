using ClassErro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desafio_AD_BD
{
    public partial class UsuarioUIL : Form
    {
        private List<Tarefas> tarefas = new List<Tarefas>();
        private int cdUsuarioLogado;

        // ================= CONSTRUTOR =================
        public UsuarioUIL(int cdUsuario)
        {
            InitializeComponent();
            cdUsuarioLogado = cdUsuario;
        }

        private void UsuarioUIL_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //Metodo para consultar o equipamento pelo patrimônio e exibir os detalhes
        private void buttonRead_Click(object sender, EventArgs e)
        {
            EquipamentoBLL equipamentoBLL = new EquipamentoBLL();

            Equipamentos equipamentos = new Equipamentos();
            equipamentos.Patrimonio = textBoxPatrimonio.Text.Trim();

            if (string.IsNullOrWhiteSpace(equipamentos.Patrimonio))
            {
                MessageBox.Show("Informe o patrimônio.");
                textBoxPatrimonio.Focus();
                return;
            }

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

            labelLocal.Text = row["Local"].ToString();
            labelLocal.Visible = true;

            labelFabricante.Text = row["Fabricante"].ToString();
            labelFabricante.Visible = true;

            labelModelo.Text = row["Modelo"].ToString();
            labelModelo.Visible = true;

            CarregarPecasPorPatrimonio(equipamentos.Patrimonio);

            textBoxPatrimonio.Enabled = false;
        }

        //Metodo para carregar as peças do equipamento no comboBox
        private void CarregarPecasPorPatrimonio(string patrimonio)
        {
            Erro.setErro(false);

            DataTable pecas = EquipamentoDAL.ListarPecasPorPatrimonio(patrimonio);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                return;
            }

            comboBoxPecas.DataSource = null;
            comboBoxPecas.Items.Clear();

            if (pecas == null || pecas.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma peça encontrada para este patrimônio.");
                return;
            }

            comboBoxPecas.DisplayMember = "Nome";
            comboBoxPecas.ValueMember = "Nome";
            comboBoxPecas.DataSource = pecas;
            comboBoxPecas.SelectedIndex = -1;
        }

        //Metodo para limpar os campos do formulário
        public void LimparCampos()
        {
            labelLocal.Visible = false;
            labelFabricante.Visible = false;
            labelModelo.Visible = false;

            labelLocal.Text = "";
            labelFabricante.Text = "";
            labelModelo.Text = "";

            comboBoxPecas.DataSource = null;
            comboBoxPecas.Text = "";

            richTextBoxObservacoes.Text = "";

            radioButtonCorretiva.Checked = false;
            radioButtonPreventiva.Checked = false;
            radioButtonReparo.Checked = false;
            radioButtonTroca.Checked = false;

            textBoxPatrimonio.Text = "";
            textBoxPatrimonio.Enabled = true;
            textBoxPatrimonio.Focus();
        }

        //Metodo para limpar os campos do formulário ao clicar no botão "Limpar"
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //Metodo para finalizar o programa ao clicar no botão "Finalizar"
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

        //Metodo para adicionar a tarefa à lista e salvar no banco de dados ao clicar no botão "Adicionar"
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Tarefas tarefa = new Tarefas();

            tarefa.Patrimonio = textBoxPatrimonio.Text.Trim();
            tarefa.Local = labelLocal.Text;
            tarefa.Fabricante = labelFabricante.Text;
            tarefa.Modelo = labelModelo.Text;
            tarefa.CdUsuario = cdUsuarioLogado;

            tarefa.TipoManutencao = radioButtonPreventiva.Checked
                ? "Preventiva"
                : radioButtonCorretiva.Checked
                    ? "Corretiva"
                    : "";

            tarefa.Peca = comboBoxPecas.Text;

            tarefa.TipoServico = radioButtonReparo.Checked
                ? "Reparo"
                : radioButtonTroca.Checked
                    ? "Troca"
                    : "";

            tarefa.DataManutencao = dateManutencao.Value;
            tarefa.Observacoes = richTextBoxObservacoes.Text.Trim();

            TarefaBLL bll = new TarefaBLL();
            bll.InserirTarefa(tarefa);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                return;
            }
            tarefas.Add(tarefa);

            MessageBox.Show("Tarefa adicionada e salva no banco com sucesso!");

            LimparCampos();
        }

        StringBuilder relatorio = new StringBuilder();

        //Metodo para gerar o relatório das tarefas ao clicar no botão "Gerar Relatório"
        private void buttonGerar_Click(object sender, EventArgs e)
        {
            if (tarefas.Count == 0)
            {
                MessageBox.Show("Nenhuma tarefa foi adicionada.");
                return;
            }
            var tarefasPorDia = tarefas
                .OrderBy(t => t.DataManutencao.Date)
                .ThenBy(t => t.Patrimonio)
                .GroupBy(t => t.DataManutencao.Date);

            foreach (var grupo in tarefasPorDia)
            {
                relatorio.AppendLine(grupo.Key.ToString("dd/MM/yyyy"));
                relatorio.AppendLine("----------------------------------------");

                foreach (Tarefas tarefa in grupo)
                {
                    relatorio.AppendLine(
                        $"{tarefa.DataManutencao:dd/MM/yyyy} - " +
                        $"Manutenção {tarefa.TipoManutencao} no equipamento " +
                        $"{tarefa.Fabricante} {tarefa.Modelo} de patrimônio {tarefa.Patrimonio} | " +
                        $"Realizado {tarefa.TipoServico} da peça {tarefa.Peca}. " +
                        $"{tarefa.Observacoes}"
                    );
                }

                relatorio.AppendLine();
            }

            previsualizacao.ShowDialog();
        }

        //Metodo para imprimir o relatório ao clicar no botão "Imprimir" na pré-visualização
        private void relatorio_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SolidBrush mCaneta = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 12);
            int linha = 10;
            e.Graphics.DrawString(relatorio.ToString(), font, mCaneta, 10, linha);
        }
    }
}