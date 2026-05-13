using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_AD_BD
{
    internal class Tarefas
    {
        public int IdTarefa { get; set; }

        public string Patrimonio { get; set; }

        public string Local { get; set; }

        public string Fabricante { get; set; }

        public string Modelo { get; set; }

        public string TipoManutencao { get; set; }

        public string Peca { get; set; }

        public string TipoServico { get; set; }

        public DateTime DataManutencao { get; set; }

        public string Observacoes { get; set; }
        public int CdUsuario { get; set; }
    }
}
