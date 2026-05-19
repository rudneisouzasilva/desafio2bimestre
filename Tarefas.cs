using System;

namespace Desafio_AD_BD
{
    internal class Tarefas
    {
        public int IdTarefa { get; set; }

        public string Patrimonio { get; set; }

        public string Peca { get; set; }

        public string LoginUsuario { get; set; }

        public string TipoManutencao { get; set; }

        public string TipoServico { get; set; }

        public DateTime DataManutencao { get; set; }

        public string Observacoes { get; set; }

        // Campos auxiliares usados apenas para exibição/relatório na tela.
        // Eles não são cadastrados diretamente na tabela Tarefa.
        public string Local { get; set; }

        public string Fabricante { get; set; }

        public string Modelo { get; set; }
    }
}