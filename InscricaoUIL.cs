using System;
using System.Windows.Forms;
using ClassErro;

namespace Desafio_AD_BD
{
    public partial class InscricaoUIL : Form
    {
        public InscricaoUIL()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}