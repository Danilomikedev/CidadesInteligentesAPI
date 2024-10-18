using CidadesInteligentesAPI.Data; // Certifique-se de que esse namespace esteja correto
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore; // Importante para o DbContext

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        // Configure o DbContext para usar um banco de dados em memória
        services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("CidadesInteligentesDB")); // Usando um banco de dados em memória para testes
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
