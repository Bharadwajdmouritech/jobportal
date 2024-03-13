using System.Text.Json.Nodes;
using JobPortalAPI.Data;
using Microsoft.EntityFrameworkCore;
using JobPortalAPI.Repository;
using JobPortalAPI.Repository.Interfaces;
using JobPortalAPI.Service.Interfaces;
using JobPortalAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();

builder.Services.AddDbContext<JobPortalDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//builder.Services.AddCors(options=>{options.AddPolicy(name:"AllowBlazorOrigin",builder=>{builder.WithOrigins("http://localhost:5024","https://localhost:7040");});});

builder.Services.AddScoped<IUnitOfWorkRepository,UnitOfWorkRepository>();
builder.Services.AddScoped<IUnitOfWorkService, UnitOfWorkService>();

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
app.UseAuthentication();
//app.UseCors("AllowBlazorOrigin");
app.UseCors(x=>x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.MapControllers();
app.Run();