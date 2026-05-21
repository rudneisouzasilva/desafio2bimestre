using ClassErro;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio_AD_BD
{
    internal class UsuarioBLL
    {
        // ================= LOGIN =================

        public string FazerLogin(string login, string senha)
        {
            Erro.setErro(false);

            login = login.Trim();
            senha = senha.Trim();

            if (login == "" || senha == "")
            {
                Erro.setMsg("Informe usuário e senha.");
                return null;
            }

            string senhaHash = GerarHashSenha(senha);

            return UsuarioDAL.ValidarLoginRetornarTipo(login, senhaHash);
        }

        // ================= CADASTRO =================

        public void CadastrarUsuario(Usuario usuario)
        {
            ValidarCampos(usuario);

            if (Erro.getErro())
                return;

            UsuarioDAL.InserirUsuario(usuario);
        }

        // ================= VALIDAÇÕES =================

        private void ValidarCampos(Usuario usuario)
        {
            Erro.setErro(false);

            usuario.Nome = usuario.Nome?.Trim();
            usuario.Login = usuario.Login?.Trim();
            usuario.Senha = usuario.Senha?.Trim();
            usuario.Telefone = usuario.Telefone?.Trim();
            usuario.Email = usuario.Email?.Trim();
            usuario.CEP = usuario.CEP?.Replace("-", "").Trim();
            usuario.Rua = usuario.Rua?.Trim();
            usuario.Numero = usuario.Numero?.Trim();
            usuario.Bairro = usuario.Bairro?.Trim();
            usuario.Cidade = usuario.Cidade?.Trim();
            usuario.UF = usuario.UF?.Trim().ToUpper();
            usuario.Complemento = usuario.Complemento?.Trim();

            if (string.IsNullOrWhiteSpace(usuario.Nome) ||
                string.IsNullOrWhiteSpace(usuario.Login) ||
                string.IsNullOrWhiteSpace(usuario.Senha) ||
                string.IsNullOrWhiteSpace(usuario.Telefone) ||
                string.IsNullOrWhiteSpace(usuario.Email) ||
                string.IsNullOrWhiteSpace(usuario.CEP) ||
                string.IsNullOrWhiteSpace(usuario.Rua) ||
                string.IsNullOrWhiteSpace(usuario.Numero) ||
                string.IsNullOrWhiteSpace(usuario.Bairro) ||
                string.IsNullOrWhiteSpace(usuario.Cidade) ||
                string.IsNullOrWhiteSpace(usuario.UF))
            {
                Erro.setMsg("Campos obrigatórios não preenchidos.");
                return;
            }

            if (!Regex.IsMatch(usuario.Email, @"^[\w\.-]+@[\w\.-]+\.\w{2,}$"))
            {
                Erro.setMsg("E-mail inválido.");
                return;
            }

            if (!Regex.IsMatch(usuario.Telefone, @"^\(?\d{2}\)?\s?\d{4,5}-?\d{4}$"))
            {
                Erro.setMsg("Telefone inválido.");
                return;
            }

            if (!Regex.IsMatch(usuario.CEP, @"^\d{8}$"))
            {
                Erro.setMsg("CEP inválido.");
                return;
            }

            if (!Regex.IsMatch(usuario.UF, @"^[A-Z]{2}$"))
            {
                Erro.setMsg("UF inválida.");
                return;
            }
        }

        // ================= SENHA =================

        public string GerarHashSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder resultado = new StringBuilder();

                foreach (byte b in hash)
                {
                    resultado.Append(b.ToString("x2"));
                }

                return resultado.ToString();
            }
        }

        // ================= CEP =================

        public async Task<Endereco> BuscarCepAsync(string cep)
        {
            Erro.setErro(false);

            cep = cep.Replace("-", "")
                     .Replace("_", "")
                     .Trim();

            if (!Regex.IsMatch(cep, @"^\d{8}$"))
            {
                Erro.setMsg("CEP inválido.");
                return null;
            }

            Endereco endereco = await ApisDAL.BuscarCepAsync(cep);

            if (endereco == null || endereco.erro == true)
            {
                Erro.setMsg("CEP não encontrado.");
                return null;
            }

            return endereco;
        }
    }
}