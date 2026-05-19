using ClassErro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Desafio_AD_BD
{
    internal class EquipamentoDAL
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

        // ================= EQUIPAMENTO =================

        public static void InserirEquipamento(Equipamentos equipamento)
        {
            Conectar();

            string sql = @"
                INSERT INTO Equipamento
                (
                    cd_patrimonio,
                    nm_local,
                    nm_fabricante,
                    nm_modelo
                )
                VALUES
                (
                    @patrimonio,
                    @local,
                    @fabricante,
                    @modelo
                )";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@patrimonio", equipamento.Patrimonio);
            cmd.Parameters.AddWithValue("@local", equipamento.Local);
            cmd.Parameters.AddWithValue("@fabricante", equipamento.Fabricante);
            cmd.Parameters.AddWithValue("@modelo", equipamento.Modelo);

            try
            {
                cmd.ExecuteNonQuery();

                SincronizarPecasDoEquipamento(equipamento);

                Erro.setErro(false);
            }
            catch (Exception ex)
            {
                Erro.setMsg("Erro ao cadastrar equipamento: " + ex.Message);
            }

            Desconectar();
        }

        public static DataTable ConsultarEquipamentoPorPatrimonio(Equipamentos equipamento)
        {
            Conectar();

            string sql = @"
                SELECT
                    e.cd_patrimonio AS Patrimonio,
                    e.nm_local AS Local,
                    e.nm_fabricante AS Fabricante,
                    e.nm_modelo AS Modelo,
                    ISNULL(STRING_AGG(p.nm_peca, ', '), '') AS Pecas
                FROM Equipamento e
                LEFT JOIN Equipamento_Peca ep
                    ON e.cd_patrimonio = ep.cd_patrimonio
                LEFT JOIN Peca p
                    ON ep.cd_peca = p.cd_peca
                WHERE e.cd_patrimonio = @patrimonio
                GROUP BY
                    e.cd_patrimonio,
                    e.nm_local,
                    e.nm_fabricante,
                    e.nm_modelo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@patrimonio", equipamento.Patrimonio);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable tabela = new DataTable();

            da.Fill(tabela);

            Desconectar();

            return tabela;
        }

        public static void AtualizarEquipamento(Equipamentos equipamento)
        {
            Conectar();

            string sql = @"
                UPDATE Equipamento
                SET
                    nm_local = @local,
                    nm_fabricante = @fabricante,
                    nm_modelo = @modelo
                WHERE cd_patrimonio = @patrimonio";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@local", equipamento.Local);
            cmd.Parameters.AddWithValue("@fabricante", equipamento.Fabricante);
            cmd.Parameters.AddWithValue("@modelo", equipamento.Modelo);
            cmd.Parameters.AddWithValue("@patrimonio", equipamento.Patrimonio);

            try
            {
                cmd.ExecuteNonQuery();

                SincronizarPecasDoEquipamento(equipamento);

                Erro.setErro(false);
            }
            catch (Exception ex)
            {
                Erro.setMsg("Erro ao atualizar equipamento: " + ex.Message);
            }

            Desconectar();
        }

        public static void ExcluirEquipamento(Equipamentos equipamento)
        {
            Conectar();

            try
            {
                string sqlTarefa = @"
                    DELETE FROM Tarefa
                    WHERE cd_patrimonio = @patrimonio";

                SqlCommand cmdTarefa = new SqlCommand(sqlTarefa, conn);
                cmdTarefa.Parameters.AddWithValue("@patrimonio", equipamento.Patrimonio);
                cmdTarefa.ExecuteNonQuery();

                string sqlPecas = @"
                    DELETE FROM Equipamento_Peca
                    WHERE cd_patrimonio = @patrimonio";

                SqlCommand cmdPecas = new SqlCommand(sqlPecas, conn);
                cmdPecas.Parameters.AddWithValue("@patrimonio", equipamento.Patrimonio);
                cmdPecas.ExecuteNonQuery();

                string sqlEquipamento = @"
                    DELETE FROM Equipamento
                    WHERE cd_patrimonio = @patrimonio";

                SqlCommand cmdEquipamento = new SqlCommand(sqlEquipamento, conn);
                cmdEquipamento.Parameters.AddWithValue("@patrimonio", equipamento.Patrimonio);
                cmdEquipamento.ExecuteNonQuery();

                Erro.setErro(false);
            }
            catch (Exception ex)
            {
                Erro.setMsg("Erro ao excluir equipamento: " + ex.Message);
            }

            Desconectar();
        }

        public static bool PatrimonioExiste(string patrimonio)
        {
            Conectar();

            string sql = @"
                SELECT COUNT(*)
                FROM Equipamento
                WHERE cd_patrimonio = @patrimonio";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@patrimonio", patrimonio);

            int quantidade = Convert.ToInt32(cmd.ExecuteScalar());

            Desconectar();

            return quantidade > 0;
        }

        // ================= PEÇAS =================

        public static DataTable ListarPecas()
        {
            Conectar();

            string sql = @"
                SELECT
                    nm_peca AS Nome
                FROM Peca
                ORDER BY nm_peca";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable tabela = new DataTable();

            da.Fill(tabela);

            Desconectar();

            return tabela;
        }

        public static DataTable ListarDistinct(string coluna)
        {
            Conectar();

            string sql = "";

            if (coluna == "Local")
            {
                sql = @"
                    SELECT DISTINCT nm_local AS Local
                    FROM Equipamento
                    ORDER BY nm_local";
            }
            else if (coluna == "Fabricante")
            {
                sql = @"
                    SELECT DISTINCT nm_fabricante AS Fabricante
                    FROM Equipamento
                    ORDER BY nm_fabricante";
            }
            else if (coluna == "Modelo")
            {
                sql = @"
                    SELECT DISTINCT nm_modelo AS Modelo
                    FROM Equipamento
                    ORDER BY nm_modelo";
            }

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable tabela = new DataTable();

            da.Fill(tabela);

            Desconectar();

            return tabela;
        }

        public static DataTable ListarPecasPorPatrimonio(string patrimonio)
        {
            Conectar();

            string sql = @"
                SELECT
                    p.nm_peca AS Nome
                FROM Peca p
                INNER JOIN Equipamento_Peca ep
                    ON p.cd_peca = ep.cd_peca
                INNER JOIN Equipamento e
                    ON ep.cd_patrimonio = e.cd_patrimonio
                WHERE e.cd_patrimonio = @patrimonio
                ORDER BY p.nm_peca";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@patrimonio", patrimonio);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable tabela = new DataTable();

            da.Fill(tabela);

            Desconectar();

            return tabela;
        }

        private static void SincronizarPecasDoEquipamento(Equipamentos equipamento)
        {
            List<int> codigosSelecionados = new List<int>();

            foreach (string nomePeca in equipamento.Pecas)
            {
                if (string.IsNullOrWhiteSpace(nomePeca))
                    continue;

                int cdPeca = BuscarOuInserirPeca(nomePeca.Trim());

                codigosSelecionados.Add(cdPeca);

                InserirVinculoSeNaoExistir(equipamento.Patrimonio, cdPeca);
            }

            List<int> codigosAtuais = BuscarCodigosPecasDoEquipamento(equipamento.Patrimonio);

            foreach (int cdPecaAtual in codigosAtuais)
            {
                if (!codigosSelecionados.Contains(cdPecaAtual))
                {
                    if (!PecaPossuiTarefa(equipamento.Patrimonio, cdPecaAtual))
                    {
                        ExcluirVinculoPeca(equipamento.Patrimonio, cdPecaAtual);
                    }
                }
            }
        }

        private static void InserirVinculoSeNaoExistir(string patrimonio, int cdPeca)
        {
            string sql = @"
                IF NOT EXISTS
                (
                    SELECT 1
                    FROM Equipamento_Peca
                    WHERE cd_patrimonio = @patrimonio
                    AND cd_peca = @cd_peca
                )
                BEGIN
                    INSERT INTO Equipamento_Peca
                    (
                        cd_patrimonio,
                        cd_peca
                    )
                    VALUES
                    (
                        @patrimonio,
                        @cd_peca
                    )
                END";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@patrimonio", patrimonio);
            cmd.Parameters.AddWithValue("@cd_peca", cdPeca);

            cmd.ExecuteNonQuery();
        }

        private static void ExcluirVinculoPeca(string patrimonio, int cdPeca)
        {
            string sql = @"
                DELETE FROM Equipamento_Peca
                WHERE cd_patrimonio = @patrimonio
                AND cd_peca = @cd_peca";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@patrimonio", patrimonio);
            cmd.Parameters.AddWithValue("@cd_peca", cdPeca);

            cmd.ExecuteNonQuery();
        }

        private static bool PecaPossuiTarefa(string patrimonio, int cdPeca)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM Tarefa
                WHERE cd_patrimonio = @patrimonio
                AND cd_peca = @cd_peca";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@patrimonio", patrimonio);
            cmd.Parameters.AddWithValue("@cd_peca", cdPeca);

            int quantidade = Convert.ToInt32(cmd.ExecuteScalar());

            return quantidade > 0;
        }

        private static List<int> BuscarCodigosPecasDoEquipamento(string patrimonio)
        {
            List<int> codigos = new List<int>();

            string sql = @"
                SELECT cd_peca
                FROM Equipamento_Peca
                WHERE cd_patrimonio = @patrimonio";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@patrimonio", patrimonio);

            SqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {
                codigos.Add(Convert.ToInt32(leitor["cd_peca"]));
            }

            leitor.Close();

            return codigos;
        }

        private static int BuscarOuInserirPeca(string nomePeca)
        {
            string sqlBusca = @"
                SELECT cd_peca
                FROM Peca
                WHERE nm_peca = @nome";

            SqlCommand cmdBusca = new SqlCommand(sqlBusca, conn);

            cmdBusca.Parameters.AddWithValue("@nome", nomePeca);

            object resultado = cmdBusca.ExecuteScalar();

            if (resultado != null)
                return Convert.ToInt32(resultado);

            string sqlInsere = @"
                INSERT INTO Peca
                (
                    nm_peca
                )
                VALUES
                (
                    @nome
                )";

            SqlCommand cmdInsere = new SqlCommand(sqlInsere, conn);

            cmdInsere.Parameters.AddWithValue("@nome", nomePeca);

            cmdInsere.ExecuteNonQuery();

            resultado = cmdBusca.ExecuteScalar();

            return Convert.ToInt32(resultado);
        }
    }
}