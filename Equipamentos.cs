using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_AD_BD
{
    internal class Equipamentos
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Patrimonio { get; set; }
        public List<string> Pecas { get; set; } = new List<string>();
    }
}
