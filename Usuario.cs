using System;

namespace Desafio_AD_BD
{
    internal class Usuario
    {
        public string Login { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string CEP { get; set; }

        public string Numero { get; set; }

        public string Tipo { get; set; }

        // Estes campos não ficam na tabela Usuario.
        // Eles são usados apenas para preencher/cadastrar a tabela CEP.
        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }
    }
}