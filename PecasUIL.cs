using ClassErro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Desafio_AD_BD
{
    public partial class PecasUIL : Form
    {
        public List<string> PecasSelecionadas { get; private set; } = new List<string>();

        // Método construtor
        public PecasUIL()
        {
            InitializeComponent();
        }

        // Evento de carregamento do formulário
        private void PecasUIL_Load(object sender, EventArgs e)
        {
            CarregarPecas();
            listBoxPecas.SelectionMode = SelectionMode.MultiSimple;
        }

        // Método para carregar as peças do banco de dados
        private void CarregarPecas()
        {
            listBoxPecas.Items.Clear();

            DataTable dt = EquipamentoDAL.ListarPecas();

            foreach (DataRow row in dt.Rows)
            {
                listBoxPecas.Items.Add(row["Nome"].ToString());
            }

            listBoxPecas.ClearSelected();
        }

        // Evento para adicionar uma nova peça
        private void buttonNovaPeca_Click(object sender, EventArgs e)
        {
            EquipamentoBLL bll = new EquipamentoBLL();

            string novaPeca = textBoxNovaPeca.Text.Trim();

            bll.ValidarNovaPeca(novaPeca);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                return;
            }

            if (!listBoxPecas.Items.Contains(novaPeca))
            {
                listBoxPecas.Items.Add(novaPeca);
            }

            textBoxNovaPeca.Text = "";
        }

        // Evento para confirmar a seleção das peças
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            PecasSelecionadas.Clear();

            foreach (var item in listBoxPecas.SelectedItems)
            {
                PecasSelecionadas.Add(item.ToString());
            }

            if (PecasSelecionadas.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma peça.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Evento para cancelar a seleção das peças
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
