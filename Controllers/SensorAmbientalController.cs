using Microsoft.AspNetCore.Mvc;
using System; // Adicione esta linha para usar DateTime

namespace CidadesInteligentesAPI.Controllers
{
    [ApiController]
    [Route("api/sensorambiental")]
    public class SensorAmbientalController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSensores()
        {
            // Simulação de dados de sensores
            var sensores = new[]
            {
                new 
                { 
                    SensorId = 1, 
                    Localizacao = "Praça da Sé", 
                    Temperatura = 25.5, 
                    Umidade = 60, 
                    QualidadeDoAr = "Boa",
                    UltimaAtualizacao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Observacoes = "Temperatura amena e umidade adequada."
                },
                new 
                { 
                    SensorId = 2, 
                    Localizacao = "Avenida Paulista", 
                    Temperatura = 26.3, 
                    Umidade = 58, 
                    QualidadeDoAr = "Moderada",
                    UltimaAtualizacao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Observacoes = "Leves variações na qualidade do ar devido ao tráfego intenso."
                },
                new 
                { 
                    SensorId = 3, 
                    Localizacao = "Parque Ibirapuera", 
                    Temperatura = 24.8, 
                    Umidade = 65, 
                    QualidadeDoAr = "Ótima",
                    UltimaAtualizacao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Observacoes = "Ambiente saudável com boa qualidade do ar."
                }
            };

            return Ok(sensores);
        }
    }
}
