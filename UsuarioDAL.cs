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
        public static int BuscarCodigoUsuarioPorLogin(string login)
        {
            Conectar();

            string sql = @"
        SELECT cd_usuario
        FROM Usuario
        WHERE ds_login = @login";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@login", login);

            object resultado = cmd.ExecuteScalar();

            Desconectar();

            if (resultado == null)
                return 0;

            return Convert.ToInt32(resultado);
        }

        // ================= CADASTRO =================

        public static void InserirUsuario(Usuario usuario)
        {
            Conectar();

            string sql = @"
        INSERT INTO Usuario
        (
            nm_usuario,
            ds_login,
            ds_senha,
            ds_telefone,
            ds_email,
            cd_cep,
            nm_rua,
            ds_numero,
            nm_bairro,
            nm_cidade,
            sg_uf,
            ds_complemento,
            ic_tipo
        )
        VALUES
        (
            @nome,
            @login,
            @senha,
            @telefone,
            @email,
            @cep,
            @rua,
            @numero,
            @bairro,
            @cidade,
            @uf,
            @complemento,
            'USUARIO'
        )";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@login", usuario.Login);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@cep", usuario.CEP);
            cmd.Parameters.AddWithValue("@rua", usuario.Rua);
            cmd.Parameters.AddWithValue("@numero", usuario.Numero);
            cmd.Parameters.AddWithValue("@bairro", usuario.Bairro);
            cmd.Parameters.AddWithValue("@cidade", usuario.Cidade);
            cmd.Parameters.AddWithValue("@uf", usuario.UF);
            cmd.Parameters.AddWithValue("@complemento", usuario.Complemento);

            try
            {
                cmd.ExecuteNonQuery();

                Erro.setErro(false);
            }
            catch (Exception ex)
            {
                Erro.setMsg("Erro ao cadastrar usuário: " + ex.Message);
            }

            Desconectar();
        }
    }
}