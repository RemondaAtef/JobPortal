using Microsoft.EntityFrameworkCore;
using WebAPI.BL.Interface;
using WebAPI.BL.Repository;
using WebAPI.DAL.Database;
using WebAPI.Extensions;
using WebAPI.Helpers;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>();



builder.Services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IJobDetailsRep, JobDetailsRep>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseCors(m => m.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

var env = app.Environment;
app.ConfigureExceptionHandler(env);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Add services to the container.
builder.Services.AddCors();

app.UseAuthorization();

app.MapControllers();



app.Run();
