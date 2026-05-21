using System;
using System.Windows.Forms;
using ClassErro;
using System.Drawing;

namespace Desafio_AD_BD
{
    public partial class InscricaoUIL : Form
    {
        //Metodo construtor
        public InscricaoUIL()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
            Estilizar();
        }

        private void Estilizar()
        {
            this.Size = new System.Drawing.Size(432, 712);
        }

        // Evento para buscar o endereço ao sair do campo de CEP
        private async void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            textBoxRua.Enabled = false;
            textBoxBairro.Enabled = false;
            textBoxCidade.Enabled = false;
            textBoxUF.Enabled = false;

            UsuarioBLL cepBLL = new UsuarioBLL();

            Endereco endereco = await cepBLL.BuscarCepAsync(maskedTextBoxCEP.Text);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());

                textBoxRua.Enabled = true;
                textBoxBairro.Enabled = true;
                textBoxCidade.Enabled = true;
                textBoxUF.Enabled = true;
                return;
            }

            if (endereco == null)
                return;

            textBoxRua.Text = endereco.logradouro;
            textBoxBairro.Text = endereco.bairro;
            textBoxCidade.Text = endereco.localidade;
            textBoxUF.Text = endereco.uf;
        }

        // Evento para mostrar ou ocultar a senha
        private void linkLabelMostrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelMostrar.Text == "Mostrar senha")
            {
                textBoxPassword.UseSystemPasswordChar = false;
                linkLabelMostrar.Text = "Ocultar senha";
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                linkLabelMostrar.Text = "Mostrar senha";
            }
        }

        // Evento para cadastrar o usuário
        private void buttonInscrever_Click(object sender, EventArgs e)
        {
            UsuarioBLL inscricaoBll = new UsuarioBLL();

            Usuario usuario = new Usuario();

            usuario.Nome = textBoxName.Text;
            usuario.Login = textBoxUser.Text;
            usuario.Senha = inscricaoBll.GerarHashSenha(textBoxPassword.Text);
            usuario.Telefone = maskedTextBoxTel.Text;
            usuario.Email = textBoxEmail.Text;
            usuario.CEP = maskedTextBoxCEP.Text.Replace("-", "").Trim();
            usuario.Rua = textBoxRua.Text;
            usuario.Numero = textBoxNumero.Text;
            usuario.Bairro = textBoxBairro.Text;
            usuario.Cidade = textBoxCidade.Text;
            usuario.UF = textBoxUF.Text;
            usuario.Complemento = textBoxComplemento.Text;

            inscricaoBll.CadastrarUsuario(usuario);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                return;
            }

            MessageBox.Show("Usuário cadastrado com sucesso!");
            this.Close();
        }

        // Evento para cancelar o cadastro
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InscricaoUIL_Load(object sender, EventArgs e)
        {
            linkLabelMostrar.Top = textBoxPassword.Top + textBoxPassword.Height;
            linkLabelMostrar.Left = textBoxPassword.Left + textBoxPassword.Width - linkLabelMostrar.Width;
        }
    }
}