using ClassErro;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Desafio_AD_BD
{
    internal class TarefaDAL
    {
        private static string strConexao = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=desafio2bimestre;Integrated Security=True";

        private static SqlConnection conn =
            new SqlConnection(strConexao);

        //================= CONEXÃO =================
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

        // ================= CADASTRAR =================
        public static void InserirTarefa(Tarefas tarefa)
        {
            Conectar();

            string sql = @"
                INSERT INTO Tarefa
                (
                    cd_patrimonio,
                    cd_peca,
                    ds_login,
                    ic_tipo_manutencao,
                    ic_tipo_servico,
                    dt_manutencao,
                    ds_observacoes
                )
                VALUES
                (
                    @patrimonio,
                    @cd_peca,
                    @login,
                    @tipo_manutencao,
                    @tipo_servico,
                    @data_manutencao,
                    @observacoes
                )";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@patrimonio", tarefa.Patrimonio);
            cmd.Parameters.AddWithValue("@cd_peca", BuscarCodigoPeca(tarefa.Peca));
            cmd.Parameters.AddWithValue("@login", tarefa.LoginUsuario);
            cmd.Parameters.AddWithValue("@tipo_manutencao", tarefa.TipoManutencao);
            cmd.Parameters.AddWithValue("@tipo_servico", tarefa.TipoServico);
            cmd.Parameters.AddWithValue("@data_manutencao", tarefa.DataManutencao);
            cmd.Parameters.AddWithValue("@observacoes", tarefa.Observacoes);

            try
            {
                cmd.ExecuteNonQuery();
                Erro.setErro(false);
            }
            catch (Exception ex)
            {
                Erro.setMsg("Erro ao cadastrar tarefa: " + ex.Message);
            }

            Desconectar();
        }

        // ================= CONSULTAR =================
        public static DataTable ConsultarManutencoes(string patrimonio, DateTime dataInicio, DateTime dataFim)
        {
            Conectar();

            string sql = @"
                SELECT
                    u.nm_usuario AS Usuario,
                    e.nm_local AS Local,
                    e.nm_fabricante + ' ' + e.nm_modelo AS Equipamento,
                    t.ic_tipo_manutencao AS Manutencao,
                    p.nm_peca AS Peca,
                    t.ic_tipo_servico AS Servico,
                    t.dt_manutencao AS Data,
                    t.ds_observacoes AS Observacoes
                FROM Tarefa t
                INNER JOIN Equipamento e
                    ON t.cd_patrimonio = e.cd_patrimonio
                INNER JOIN Peca p
                    ON t.cd_peca = p.cd_peca
                INNER JOIN Usuario u
                    ON t.ds_login = u.ds_login
                WHERE t.cd_patrimonio = @patrimonio
                AND t.dt_manutencao BETWEEN @inicio AND @fim
                ORDER BY t.dt_manutencao";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@patrimonio", patrimonio);
            cmd.Parameters.AddWithValue("@inicio", dataInicio);
            cmd.Parameters.AddWithValue("@fim", dataFim);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable tabela = new DataTable();

            da.Fill(tabela);

            Desconectar();

            return tabela;
        }

        //Metodo para buscar o código da peça com base no nome
        private static int BuscarCodigoPeca(string nomePeca)
        {
            string sql = @"
                SELECT cd_peca
                FROM Peca
                WHERE nm_peca = @nomePeca";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nomePeca", nomePeca);

            object resultado = cmd.ExecuteScalar();

            if (resultado == null)
                return 0;

            return Convert.ToInt32(resultado);
        }
    }
}