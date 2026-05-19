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
            Estilizar();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void Estilizar()
        {
            // Form
            this.Size = new Size(344, 460);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            this.Text = "SIGEM";

            // Label SIGEM
            labelSigem.Font = new Font("Segoe UI", 10);
            labelSigem.ForeColor = ColorTranslator.FromHtml("#888780");
            labelSigem.Location = new Point(32, 28);

            // Label título
            labelTitulo.Font = new Font("Segoe UI", 16);
            labelTitulo.ForeColor = ColorTranslator.FromHtml("#2C2C2A");
            labelTitulo.MaximumSize = new Size(264, 0);
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(32, 46);

            // Label Usuário
            labelUsuario.Font = new Font("Segoe UI", 11);
            labelUsuario.ForeColor = ColorTranslator.FromHtml("#888780");

            // TextBox usuário
            textBoxLogin.Size = new Size(264, 40);
            textBoxLogin.BackColor = ColorTranslator.FromHtml("#F1EFE8");
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Font = new Font("Segoe UI", 12);

            // Label Senha
            labelSenha.Font = new Font("Segoe UI", 11);
            labelSenha.ForeColor = ColorTranslator.FromHtml("#888780");

            // TextBox senha
            textBoxPassword.Size = new Size(264, 40);
            textBoxPassword.BackColor = ColorTranslator.FromHtml("#F1EFE8");
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 12);

            // LinkLabel mostrar senha
            linkLabelMostrar.Font = new Font("Segoe UI", 11);
            linkLabelMostrar.LinkColor = ColorTranslator.FromHtml("#888780");
            linkLabelMostrar.ActiveLinkColor = ColorTranslator.FromHtml("#2C2C2A");

            // Button Entrar
            buttonEntrar.Size = new Size(264, 40);
            buttonEntrar.BackColor = ColorTranslator.FromHtml("#1A1A18");
            buttonEntrar.ForeColor = ColorTranslator.FromHtml("#F1EFE8");
            buttonEntrar.FlatStyle = FlatStyle.Flat;
            buttonEntrar.FlatAppearance.BorderSize = 0;
            buttonEntrar.Font = new Font("Segoe UI", 12);
            buttonEntrar.Cursor = Cursors.Hand;

            // LinkLabel inscreva-se
            linkLabelInscrever.Font = new Font("Segoe UI", 11);
            linkLabelInscrever.ForeColor = ColorTranslator.FromHtml("#888780");
            linkLabelInscrever.LinkColor = ColorTranslator.FromHtml("#2C2C2A");

        }

        private void LoginUIL_Load(object sender, EventArgs e)
        {
            labelUsuario.Top = labelTitulo.Bottom + 24;
            labelUsuario.Left = 32;
            textBoxLogin.Top = labelUsuario.Bottom + 5;
            textBoxLogin.Left = 32;

            labelSenha.Top = textBoxLogin.Bottom + 12;
            labelSenha.Left = 32;
            textBoxPassword.Top = labelSenha.Bottom + 5;
            textBoxPassword.Left = 32;

            linkLabelMostrar.Top = textBoxPassword.Bottom + 4;
            linkLabelMostrar.Left = 32 + 264 - linkLabelMostrar.Width;

            buttonEntrar.Top = linkLabelMostrar.Bottom + 16;
            buttonEntrar.Left = 32;

            linkLabelInscrever.Top = buttonEntrar.Bottom + 14;
            linkLabelInscrever.Left = 32;
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
                tela = new UsuarioUIL(textBoxLogin.Text.Trim());
            }
            tela.Show();
        }
    }
}
