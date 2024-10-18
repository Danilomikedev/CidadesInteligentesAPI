using Microsoft.EntityFrameworkCore;
using CidadesInteligentesAPI.Models; // Certifique-se de que esse namespace esteja correto

namespace CidadesInteligentesAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet para suas entidades
        public DbSet<DadosDeTrafego> DadosDeTrafego { get; set; }
        public DbSet<SensorAmbiental> SensorAmbiental { get; set; }
    }
}
