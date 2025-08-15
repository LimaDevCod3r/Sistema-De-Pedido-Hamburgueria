using Microsoft.EntityFrameworkCore;
using SistemaDePedidoHamburgueria.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Obtém a string de conexão do banco de dados MySQL do arquivo de configuração
var databaseSQLConnection = builder.Configuration.GetConnectionString("DefaultConnection");

// Configura o Entity Framework Core com MySQL
// Usa o Pomelo.EntityFrameworkCore.MySql para conectar ao MySQL
// ServerVersion.AutoDetect detecta automaticamente a versão do servidor MySQL
builder.Services.AddDbContext<HamburgueriaApiDBContext>(options =>
    options.UseMySql(databaseSQLConnection, ServerVersion.AutoDetect(databaseSQLConnection))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "Hamburgueria API");
        options.DocumentTitle = "Sistema de Pedido - Hamburgueria";
    });
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();

