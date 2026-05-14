using ClassErro;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Desafio_AD_BD
{
    internal class TarefaDAL
    {
        private static string strConexao =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=desafio2bimestre;Integrated Security=True";

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
                    cd_usuario,
                    cd_equipamento,
                    cd_peca,
                    ic_tipo_manutencao,
                    ic_tipo_servico,
                    dt_manutencao,
                    ds_observacoes
                )
                VALUES
                (
                    @cd_usuario,
                    @cd_equipamento,
                    @cd_peca,
                    @tipo_manutencao,
                    @tipo_servico,
                    @data_manutencao,
                    @observacoes
                )";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cd_usuario", tarefa.CdUsuario);
            cmd.Parameters.AddWithValue("@cd_equipamento", BuscarCodigoEquipamento(tarefa.Patrimonio));
            cmd.Parameters.AddWithValue("@cd_peca", BuscarCodigoPeca(tarefa.Peca));
            cmd.Parameters.AddWithValue("@tipo_manutencao", tarefa.TipoManutencao);
            cmd.Parameters.AddWithValue("@tipo_servico", tarefa.TipoServico);
            cmd.Parameters.AddWithValue("@data_manutencao", tarefa.DataManutencao);
            cmd.Parameters.AddWithValue("@observacoes", tarefa.Observacoes);

            try
            {
                cmd.ExecuteNonQuery();
                Erro.setErro(false);
            }
            catch (Exception)
            {
                Erro.setMsg("Erro ao cadastrar tarefa.");
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
                            ON t.cd_equipamento = e.cd_equipamento
                        INNER JOIN Peca p
                            ON t.cd_peca = p.cd_peca
                        INNER JOIN Usuario u
                            ON t.cd_usuario = u.cd_usuario
                        WHERE e.cd_patrimonio = @patrimonio
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

        //Metodo para buscar o código do equipamento com base no patrimônio
        private static int BuscarCodigoEquipamento(string patrimonio)
        {
            string sql = @"
                SELECT cd_equipamento
                FROM Equipamento
                WHERE cd_patrimonio = @patrimonio";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@patrimonio", patrimonio);

            object resultado = cmd.ExecuteScalar();

            if (resultado == null)
                return 0;

            return Convert.ToInt32(resultado);
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