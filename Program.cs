using Microsoft.EntityFrameworkCore;
using SaveUpAPI.Models;
using SaveUpAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDataManagmentService, DataManagmentSevice>();

// Add services to the container.
builder.Services.AddDbContext<SaveUpContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
