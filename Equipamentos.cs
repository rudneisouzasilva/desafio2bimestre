using System.Collections.Generic;

namespace Desafio_AD_BD
{
    internal class Equipamentos
    {
        public string Patrimonio { get; set; }

        public string Local { get; set; }

        public string Fabricante { get; set; }

        public string Modelo { get; set; }

        public List<string> Pecas { get; set; } = new List<string>();
    }
}