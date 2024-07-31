using Microsoft.EntityFrameworkCore;
using Oficina_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//exemplo tutorial
//builder.Services.AddDbContext<PecaContext>(opt =>
//    opt.UseInMemoryDatabase("PecaList"));

builder.Services.AddDbContext<PecaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PecaContext")));

builder.Services.AddDbContext<MovimentoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovimentoContext")));

builder.Services.AddDbContext<ReparacaoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ReparacaoContext")));

builder.Services.AddDbContext<Peca_reparacaoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Peca_reparacaoContext")));

builder.Services.AddDbContext<Peca_reparacaoDTOContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Peca_reparacaoDTOContext")));

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseDeveloperExceptionPage();
   //app.UseSwagger();
   //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
