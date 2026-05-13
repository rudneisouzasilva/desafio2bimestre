using ClassErro;
using System;
using System.Data;

namespace Desafio_AD_BD
{
    internal class TarefaBLL
    {
        // ================= CADASTRAR =================

        public void InserirTarefa(Tarefas tarefa)
        {
            ValidarTarefa(tarefa);

            if (Erro.getErro())
                return;

            TarefaDAL.InserirTarefa(tarefa);
        }

        // ================= CONSULTAR =================

        public DataTable ConsultarManutencoes
        (
            string patrimonio,
            DateTime dataInicio,
            DateTime dataFim
        )
        {
            if (patrimonio.Trim() == "")
            {
                Erro.setMsg("Informe o patrimônio.");
                return null;
            }

            if (dataFim < dataInicio)
            {
                Erro.setMsg("Data final inválida.");
                return null;
            }

            return TarefaDAL.ConsultarManutencoes
            (
                patrimonio,
                dataInicio,
                dataFim
            );
        }

        // ================= VALIDAÇÕES =================

        private void ValidarTarefa(Tarefas tarefa)
        {
            Erro.setErro(false);

            if (string.IsNullOrWhiteSpace(tarefa.Patrimonio))
            {
                Erro.setMsg("Informe o patrimônio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tarefa.TipoManutencao))
            {
                Erro.setMsg("Informe o tipo de manutenção.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tarefa.Peca))
            {
                Erro.setMsg("Informe a peça.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tarefa.TipoServico))
            {
                Erro.setMsg("Informe o tipo de serviço.");
                return;
            }

            if (tarefa.DataManutencao == DateTime.MinValue)
            {
                Erro.setMsg("Informe a data.");
                return;
            }
        }
    }
}
