using ClassErro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_AD_BD
{
    public partial class LoginUIL : Form
    {
        public LoginUIL()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void linkLabelInscrever_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InscricaoUIL inscricao = new InscricaoUIL();
            inscricao.Show();
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

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            UsuarioBLL loginBLL = new UsuarioBLL();

            string tipo = loginBLL.FazerLogin(
                textBoxLogin.Text,
                textBoxPassword.Text
            );

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                return;
            }

            if (tipo == null)
            {
                MessageBox.Show("Login ou senha inválidos.");
                return;
            }

            Form tela;

            if (tipo == "ADMIN")
            {
                tela = new AdministradorUIL();
            }
            else
            {
                int cdUsuario = UsuarioDAL.BuscarCodigoUsuarioPorLogin(textBoxLogin.Text.Trim());
                tela = new UsuarioUIL(cdUsuario);
            }
            tela.Show();
        }
    }
}
