using Application_Layer.Injection;
using WebAPI.Middleware;
using Infrastructure_Layer.Injection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container. ( MediatR, AutoMapper )

builder.Services.AddApplicationLayer();
builder.Services.AddInfrastructureLayer(builder.Configuration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddGrpc();

var app = builder.Build();

// configure method to set up middleware

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<CustomExceptionHandlerMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
