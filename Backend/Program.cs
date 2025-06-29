using Microsoft.OpenApi.Models;
using ToolTrack.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar configuraci�n de servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Swagger con t�tulo personalizado (opcional)
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ToolTrack API", Version = "v1" });
});

// Configurar inyecci�n de dependencias para MongoDB (servicio de herramientas)
builder.Services.AddSingleton<HerramientaService>(); // Este es tu servicio que conecta con MongoDB

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
