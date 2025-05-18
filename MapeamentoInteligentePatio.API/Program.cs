
using Microsoft.EntityFrameworkCore;
using MapeamentoInteligentePatio.Application.Interfaces;
using MapeamentoInteligentePatio.Application.Services;
using MapeamentoInteligentePatio.Infrastructure.Data;
using MapeamentoInteligentePatio.API.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB Context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection")));

// AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Services
builder.Services.AddScoped<IMotoService, MotoService>();
builder.Services.AddScoped<IFilialService, FilialService>();

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
