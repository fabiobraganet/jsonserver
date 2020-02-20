
namespace Projeto.Services
{
    using Projeto.Model;

    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class EnderecoServices
    {

        private readonly HttpClient _httpClient;

        public EnderecoServices(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<Endereco>> BuscarTodos()
        {
            var response = await _httpClient.GetAsync("/enderecos");

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<List<Endereco>>(content);
        }

    }
}
