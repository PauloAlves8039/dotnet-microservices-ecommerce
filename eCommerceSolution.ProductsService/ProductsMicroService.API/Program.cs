using BusinessLogicLayer.Configurations;
using DataAccessLayer.Configurations;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDataAccessLayer(builder.Configuration);
builder.Services.AddBusinessLogicLayer();

builder.Services.AddControllers();

builder.Services.AddFluentValidationAutoValidation();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
