using Avaliacao3.Business;
using Avaliacao3.Business.Interface;
using Avaliacao3.Controllers;
using Avaliacao3.DB;
using Avaliacao3.Model;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          
                          //policy.WithMethods("DELETE", "GET", "POST", "PUT");
                          policy.AllowAnyMethod();
                          policy.AllowAnyHeader();
                          policy.AllowAnyOrigin();
                      });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Repositorios
builder.Services.AddScoped<Context>();
builder.Services.AddScoped<IRepository<Cliente_MD>, SqlEntityRepository<Cliente_MD>>();
builder.Services.AddScoped<IRepository<Error_MD>, SqlRawRepository<Error_MD>>();

//Business e Controllers
builder.Services.AddScoped<ICliente_Business, Cliente_Business>();
builder.Services.AddScoped<ClienteController>();
builder.Services.AddScoped<IError_Business, Error_Business>();
builder.Services.AddScoped<ErrorController>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
Context.CreateBase();

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
