using CharanpreeetSingh.Interface;
using CharanpreeetSingh.Repositories;
using CharanpreetSingh.DataBaseContext;
using Microsoft.EntityFrameworkCore;
//using CharanpreeetSingh.Models;
//using CharanpreeetSingh.Repository;

var builder = WebApplication.CreateBuilder(args);


string connString = builder.Configuration.GetConnectionString("ProductDB");

//var connectionString = builder.Configuration.GetConnectionString("ProductDB");
//builder.Services.AddDbContext(option =>
//option.UseSqlServer(connectionString)
//);

builder.Services.AddDbContext<CharanPreetDBContext>(options =>
{
    options.UseSqlServer(connString);

});

builder.Services.AddScoped<IProfile, ProfileRepository>();

// Add services to the container.

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
