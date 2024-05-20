using Microsoft.EntityFrameworkCore;
using Pedidos.Mapeos;
using Repositorio;
using Repositorio.Data;
using Repositorio.Interfaces;
using Servicio.Interfaces;
using Servicio;

var builder = WebApplication.CreateBuilder(args);


var connection = builder.Configuration.GetConnectionString("connectionWindows");

//Inyección de Dependencias

builder.Services.AddDbContext<DbContexto>(opt => opt.UseSqlServer(connection));
builder.Services.AddAutoMapper(typeof(AutoMaperPerfil));
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();
builder.Services.AddScoped<IVehiculoRepository, VehiculoRepository>();
builder.Services.AddScoped<IVehiculoService, VehiculoService>();
builder.Services.AddScoped<IConductorRepository, ConductorRepository>();
builder.Services.AddScoped<IConductorService, ConductorService>();
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IPedidoService, PedidoService>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
