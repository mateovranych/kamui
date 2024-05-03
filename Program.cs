using kamui.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

var ServerVersion = new MySqlServerVersion(new Version(8, 0, 33));

builder.Services.AddDbContext<appDbContext>(options => options.UseMySql(connectionString, ServerVersion));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program).Assembly);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI(c =>

	c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
}



// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
