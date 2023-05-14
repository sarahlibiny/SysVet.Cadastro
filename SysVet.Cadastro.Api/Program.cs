using SysVet.Cadastro.Dominio.Interfaces;
using SysVet.Cadastro.Dominio.Servicos;
using SysVet.Cadastro.Infra.Data.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAnimalRepositorio, AnimalRepositorio>();
builder.Services.AddScoped<IAnimalServico, AnimalServico>();
builder.Services.AddScoped<ITutorRepositorio, TutorRepositorio>();
builder.Services.AddScoped<ITutorServico, TutorServico>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
