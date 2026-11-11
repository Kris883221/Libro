using Catalogo.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Registrar el contexto de Entity Framework
builder.Services.AddDbContext<CatalogoDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CatalogoConnection")));

// (El resto del código predeterminado de Swagger/OpenAPI se mantiene igual)
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();