using ClassErro;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Desafio_AD_BD
{
    internal class ApisDAL
    {
        public static async Task<Endereco> BuscarCepAsync(string cep)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url =
                        $"https://viacep.com.br/ws/{cep}/json/";

                    string json =
                        await client.GetStringAsync(url);

                    return JsonSerializer.Deserialize<Endereco>(json);
                }
            }
            catch
            {
                Erro.setMsg("Erro ao consultar o CEP.");

                return null;
            }
        }
    }
}