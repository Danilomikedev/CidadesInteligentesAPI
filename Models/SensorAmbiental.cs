using System;

namespace CidadesInteligentesAPI.Models
{
    public class SensorAmbiental
    {
        public int Id { get; set; }
        public string TipoSensor { get; set; }
        public double Valor { get; set; }
        public DateTime DataRegistro { get; set; } // Certifique-se de que esta linha está correta
    }
}
