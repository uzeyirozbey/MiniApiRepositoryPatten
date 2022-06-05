using AppRepositoryPatten.Contracts;
using AppRepositoryPatten.Entities;
using AppRepositoryPatten.Entities.Models;
using AppRepositoryPatten.Repository;
using AppRepositoryPatten.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Repository Context
builder.Services.ConfigureCors();
builder.Services.AddTransient<RepositoryContext>();
builder.Services.AddScoped<IOgrenciRepository, OgrenciRepository>();
builder.Services.AddDbContext<RepositoryContext>(
        options => options.UseSqlServer(
            "Data Source=DESKTOP-P613N16;Initial Catalog=ogrenciDb;Integrated Security=True;",
            providerOptions => providerOptions.EnableRetryOnFailure()));
builder.Services.ConfigureMySqlContext(builder.Configuration);
builder.Services.ConfigureRepositoryWrapper();
builder.Services.AddControllers();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

app.MapPost("/ogrenciEkle",  (Ogrenci ogrenciRequest, IOgrenciRepository ogrenciSevice)
    =>  ogrenciSevice.Ekle(ogrenciRequest));

app.MapGet("/ogrenciListele",   (IOgrenciRepository ogrenciSevice)
    =>   ogrenciSevice.Listele());
app.Run();