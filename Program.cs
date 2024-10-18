using Microsoft.AspNetCore.Builder; // Para WebApplication
using Microsoft.Extensions.DependencyInjection; // Para AddControllers
using Microsoft.OpenApi.Models; // Para OpenApiInfo
using Microsoft.Extensions.Hosting; // Para IHostEnvironment
using Microsoft.AspNetCore.Http; // Para HttpContext


var builder = WebApplication.CreateBuilder(args);

// Adicione serviços ao contêiner
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cidades Inteligentes API", Version = "v1" });
});

var app = builder.Build();

// Configure o pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cidades Inteligentes API v1"));
}

// Habilita o uso de arquivos estáticos
app.UseStaticFiles();

// Mapeia a página inicial para o arquivo index.html
app.MapGet("/", async context =>
{
    context.Response.Redirect("/index.html", true);
});

// Configura as rotas dos controllers
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
