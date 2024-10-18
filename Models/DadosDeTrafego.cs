using System;

namespace CidadesInteligentesAPI.Models
{
    public class DadosDeTrafego
    {
        public int Id { get; set; }
        public string Localizacao { get; set; }
        public int VolumeVeicular { get; set; }
        public DateTime DataRegistro { get; set; } // Certifique-se de que esta linha está correta
    }
}
