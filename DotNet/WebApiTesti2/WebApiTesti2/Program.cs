/*
Scaffold-DbContext "Server=localhost\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=no;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
*/

var builder = WebApplication.CreateBuilder(args);

// CORS-asetukset
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CodeBootcamp",
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                          policy.AllowAnyHeader();
                          policy.AllowAnyMethod();
                          /*
                          policy.WithOrigins("http://example.com",
                                             "http://www.contoso.com");
                          */
                      });
});

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

app.UseCors("CodeBootcamp");

app.UseAuthorization();

app.MapControllers();

app.Run();
