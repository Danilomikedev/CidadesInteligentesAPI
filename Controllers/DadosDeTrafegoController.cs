using Microsoft.AspNetCore.Mvc;
using System; // Adicione esta linha para usar DateTime

namespace CidadesInteligentesAPI.Controllers
{
    [ApiController]
    [Route("api/dadosdetrafego")]
    public class DadosDeTrafegoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDadosTrafego()
        {
            // Simulação de dados de tráfego
            var dadosTrafego = new
            {
                Veiculos = 150,
                Congestionamento = "Moderado",
                TempoEstimado = "20 minutos",
                UltimaAtualizacao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Vias = new[]
                {
                    new 
                    { 
                        Nome = "Avenida Paulista", 
                        Veiculos = 60, 
                        Congestionamento = "Moderado", 
                        TempoEstimado = "10 minutos",
                        Descricao = "A principal avenida da cidade, conhecida por seus centros comerciais e culturais."
                    },
                    new 
                    { 
                        Nome = "Rua da Consolação", 
                        Veiculos = 40, 
                        Congestionamento = "Leve", 
                        TempoEstimado = "5 minutos",
                        Descricao = "Uma rua importante que conecta a Avenida Paulista ao centro da cidade."
                    },
                    new 
                    { 
                        Nome = "Avenida Brigadeiro Faria Lima", 
                        Veiculos = 50, 
                        Congestionamento = "Alto", 
                        TempoEstimado = "15 minutos",
                        Descricao = "Uma das principais avenidas financeiras da cidade, com alto fluxo de veículos."
                    }
                }
            };

            return Ok(dadosTrafego);
        }
    }
}
