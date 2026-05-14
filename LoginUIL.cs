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
        //Metodo construtor para inicializar os componentes da interface e configurar a caixa de senha
        public LoginUIL()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        //Metodo para abrir a tela de inscrição
        private void linkLabelInscrever_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InscricaoUIL inscricao = new InscricaoUIL();
            inscricao.Show();
        }

        //Metodo para mostrar ou ocultar a senha
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

        //Metodo para realizar o login do usuário e abrir a tela correspondente ao tipo de usuário
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            UsuarioBLL loginBLL = new UsuarioBLL();

            string tipo = loginBLL.FazerLogin(textBoxLogin.Text, textBoxPassword.Text);

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
