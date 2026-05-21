using ClassErro;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Desafio_AD_BD
{
    internal class UsuarioDAL
    {
        private static string strConexao = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=desafio2bimestre;Integrated Security=True";

        private static SqlConnection conn =
            new SqlConnection(strConexao);

        // ================= CONEXÃO =================

        public static void Conectar()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public static void Desconectar()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        // ================= LOGIN =================

        public static string ValidarLoginRetornarTipo(string login, string senha)
        {
            Conectar();

            string sql = @"
                SELECT ic_tipo
                FROM Usuario
                WHERE ds_login = @login
                AND ds_senha = @senha";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            object resultado = cmd.ExecuteScalar();

            Desconectar();

            if (resultado == null)
                return null;

            return resultado.ToString();
        }

        // ================= CADASTRO =================

        public static void InserirUsuario(Usuario usuario)
        {
            Conectar();

            try
            {
                InserirCepSeNaoExistir(usuario);

                string sql = @"
                    INSERT INTO Usuario
                    (
                        ds_login,
                        cd_cep,
                        ds_senha,
                        nm_usuario,
                        ds_telefone,
                        ds_email,
                        ds_numero,
                        ds_complemento,
                        ic_tipo
                    )
                    VALUES
                    (
                        @login,
                        @cep,
                        @senha,
                        @nome,
                        @telefone,
                        @email,
                        @numero,
                        @complemento,
                        @tipo
                    )";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@login", usuario.Login);
                cmd.Parameters.AddWithValue("@cep", usuario.CEP);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@numero", usuario.Numero);
                cmd.Parameters.AddWithValue("@complemento", usuario.Complemento);

                if (string.IsNullOrWhiteSpace(usuario.Tipo))
                    cmd.Parameters.AddWithValue("@tipo", "USUARIO");
                else
                    cmd.Parameters.AddWithValue("@tipo", usuario.Tipo);

                cmd.ExecuteNonQuery();

                Erro.setErro(false);
            }
            catch (Exception ex)
            {
                Erro.setMsg("Erro ao cadastrar usuário: " + ex.Message);
            }

            Desconectar();
        }

        // ================= CEP =================

        private static void InserirCepSeNaoExistir(Usuario usuario)
        {
            string sqlConsulta = @"
                SELECT COUNT(*)
                FROM CEP
                WHERE cd_cep = @cep";

            SqlCommand cmdConsulta = new SqlCommand(sqlConsulta, conn);
            cmdConsulta.Parameters.AddWithValue("@cep", usuario.CEP);

            int quantidade = Convert.ToInt32(cmdConsulta.ExecuteScalar());

            if (quantidade > 0)
                return;

            string sqlInsere = @"
                INSERT INTO CEP
                (
                    cd_cep,
                    nm_rua,
                    nm_bairro,
                    nm_cidade,
                    sg_uf
                )
                VALUES
                (
                    @cep,
                    @rua,
                    @bairro,
                    @cidade,
                    @uf
                )";

            SqlCommand cmdInsere = new SqlCommand(sqlInsere, conn);

            cmdInsere.Parameters.AddWithValue("@cep", usuario.CEP);
            cmdInsere.Parameters.AddWithValue("@rua", usuario.Rua);
            cmdInsere.Parameters.AddWithValue("@bairro", usuario.Bairro);
            cmdInsere.Parameters.AddWithValue("@cidade", usuario.Cidade);
            cmdInsere.Parameters.AddWithValue("@uf", usuario.UF);

            cmdInsere.ExecuteNonQuery();
        }
    }
}