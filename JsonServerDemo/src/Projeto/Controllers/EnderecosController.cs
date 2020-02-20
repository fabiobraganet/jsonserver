
namespace Projeto.Controllers
{
    using Projeto.Model;
    using Projeto.Services;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [ApiController]
    [Route("[controller]")]
    public class EnderecosController : ControllerBase
    {
        private readonly ILogger<EnderecosController> _logger;
        private readonly EnderecoServices _enderecoServices;

        public EnderecosController(ILogger<EnderecosController> logger, EnderecoServices enderecoservices)
        {
            _logger = logger;
            _enderecoServices = enderecoservices;
        }

        [HttpGet]
        public async Task<List<Endereco>> Get()
        {
            _logger.LogInformation("Buscando todos os endereços");
            
            var result = await _enderecoServices.BuscarTodos();

            if (result != null)
                _logger.LogInformation($"Total de {result.Count}");
            else
                _logger.LogError("O processo de buscar todos os endereços falhou.");

            return await Task.FromResult(result);
        }
    }
}
