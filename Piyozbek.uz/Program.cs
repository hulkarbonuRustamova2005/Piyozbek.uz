using Microsoft.EntityFrameworkCore;
using Piyozbek.uz.DataAccess;
using Piyozbek.uz.DataAccess.Repositories;
using Piyozbek.uz.Dtos;
using Piyozbek.uz.Endpoints;
using Piyozbek.uz.Maps;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ICarRepository, CarRepository>();    
builder.Services.AddScoped <IDriverRepository,DriverRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapCarENdPoints()
    .MapDriverENdPoints();

app.Run();



