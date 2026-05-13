using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_AD_BD
{
    internal class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public string Telefone { get; set; }
        public string Email { get; set; }

        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Complemento { get; set; }
    }
}
