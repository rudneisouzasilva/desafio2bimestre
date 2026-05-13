using ClassErro;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Desafio_AD_BD
{
    internal class EquipamentoDAL
    {
        private static string strConexao =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=desafio2bimestre;Integrated Security=True";

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
                    nm_local,
                    nm_fabricante,
                    nm_modelo,
                    cd_patrimonio
                )
                VALUES
                (
                    @local,
                    @fabricante,
                    @modelo,
                    @patrimonio
                )";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@local", equipamento.Local);
            cmd.Parameters.AddWithValue("@fabricante", equipamento.Fabricante);
            cmd.Parameters.AddWithValue("@modelo", equipamento.Modelo);
            cmd.Parameters.AddWithValue("@patrimonio", equipamento.Patrimonio);

            try
            {
                cmd.ExecuteNonQuery();

                InserirPecasDoEquipamento(equipamento);

                Erro.setErro(false);
            }
            catch (Exception)
            {
                Erro.setMsg("Erro ao cadastrar equipamento.");
            }

            Desconectar();
        }

        public static DataTable ConsultarEquipamentoPorPatrimonio(Equipamentos equipamento)
        {
            Conectar();

            string sql = @"
        SELECT
            e.cd_equipamento,
            e.nm_local AS Local,
            e.nm_fabricante AS Fabricante,
            e.nm_modelo AS Modelo,
            e.cd_patrimonio AS Patrimonio,
            ISNULL(STRING_AGG(p.nm_peca, ', '), '') AS Pecas
        FROM Equipamento e
        LEFT JOIN Equipamento_Peca ep
            ON e.cd_equipamento = ep.cd_equipamento
        LEFT JOIN Peca p
            ON ep.cd_peca = p.cd_peca
        WHERE e.cd_patrimonio = @patrimonio
        GROUP BY
            e.cd_equipamento,
            e.nm_local,
            e.nm_fabricante,
            e.nm_modelo,
            e.cd_patrimonio";

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

                ExcluirPecasDoEquipamento(equipamento.Patrimonio);
                InserirPecasDoEquipamento(equipamento);

                Erro.setErro(false);
            }
            catch (Exception)
            {
                Erro.setMsg("Erro ao atualizar equipamento.");
            }

            Desconectar();
        }

        public static void ExcluirEquipamento(Equipamentos equipamento)
        {
            Conectar();

            try
            {
                int cdEquipamento = BuscarCodigoEquipamento(equipamento.Patrimonio);

                string sqlTarefa = @"
            DELETE FROM Tarefa
            WHERE cd_equipamento = @cd_equipamento";

                SqlCommand cmdTarefa = new SqlCommand(sqlTarefa, conn);
                cmdTarefa.Parameters.AddWithValue("@cd_equipamento", cdEquipamento);
                cmdTarefa.ExecuteNonQuery();

                string sqlPecas = @"
            DELETE FROM Equipamento_Peca
            WHERE cd_equipamento = @cd_equipamento";

                SqlCommand cmdPecas = new SqlCommand(sqlPecas, conn);
                cmdPecas.Parameters.AddWithValue("@cd_equipamento", cdEquipamento);
                cmdPecas.ExecuteNonQuery();

                string sqlEquipamento = @"
            DELETE FROM Equipamento
            WHERE cd_equipamento = @cd_equipamento";

                SqlCommand cmdEquipamento = new SqlCommand(sqlEquipamento, conn);
                cmdEquipamento.Parameters.AddWithValue("@cd_equipamento", cdEquipamento);
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
                    ON ep.cd_equipamento = e.cd_equipamento
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

        private static void InserirPecasDoEquipamento(Equipamentos equipamento)
        {
            int cdEquipamento = BuscarCodigoEquipamento(equipamento.Patrimonio);

            foreach (string nomePeca in equipamento.Pecas)
            {
                int cdPeca = BuscarOuInserirPeca(nomePeca);

                string sql = @"
                    INSERT INTO Equipamento_Peca
                    (
                        cd_equipamento,
                        cd_peca
                    )
                    VALUES
                    (
                        @cd_equipamento,
                        @cd_peca
                    )";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@cd_equipamento", cdEquipamento);
                cmd.Parameters.AddWithValue("@cd_peca", cdPeca);

                cmd.ExecuteNonQuery();
            }
        }

        private static void ExcluirPecasDoEquipamento(string patrimonio)
        {
            int cdEquipamento = BuscarCodigoEquipamento(patrimonio);

            string sql = @"
                DELETE FROM Equipamento_Peca
                WHERE cd_equipamento = @cd_equipamento";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cd_equipamento", cdEquipamento);

            cmd.ExecuteNonQuery();
        }

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
