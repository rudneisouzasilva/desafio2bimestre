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
        private List<string> pecasPreSelecionadas = new List<string>();

        // Método construtor
        public PecasUIL()
        {
            InitializeComponent();
            textBoxNovaPeca.Size = new System.Drawing.Size(textBoxNovaPeca.Width, buttonNovaPeca.Height);
        }
        public PecasUIL(List<string> pecasAtuais)
        {
            InitializeComponent();

            textBoxNovaPeca.Size = new System.Drawing.Size(textBoxNovaPeca.Width, buttonNovaPeca.Height);

            if (pecasAtuais != null)
            {
                pecasPreSelecionadas = new List<string>(pecasAtuais);
            }
        }

        // Evento de carregamento do formulário
        private void PecasUIL_Load(object sender, EventArgs e)
        {
            listBoxPecas.SelectionMode = SelectionMode.MultiSimple;
            CarregarPecas();
            MarcarPecasPreSelecionadas();
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
        private void MarcarPecasPreSelecionadas()
        {
            if (pecasPreSelecionadas == null || pecasPreSelecionadas.Count == 0)
                return;

            for (int i = 0; i < listBoxPecas.Items.Count; i++)
            {
                string nomePeca = listBoxPecas.Items[i].ToString();

                if (pecasPreSelecionadas.Contains(nomePeca))
                {
                    listBoxPecas.SetSelected(i, true);
                }
            }
        }

        // Evento para adicionar uma nova peça
        private void buttonNovaPeca_Click(object sender, EventArgs e)
        {
            EquipamentoBLL bll = new EquipamentoBLL();

            string novaPeca = textBoxNovaPeca.Text.Trim();

            bll.ValidarNovaPeca(novaPeca);

            if (!listBoxPecas.Items.Contains(novaPeca))
            {
                listBoxPecas.Items.Add(novaPeca);
            }

            int indice = listBoxPecas.Items.IndexOf(novaPeca);

            if (indice >= 0)
            {
                listBoxPecas.SetSelected(indice, true);
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
