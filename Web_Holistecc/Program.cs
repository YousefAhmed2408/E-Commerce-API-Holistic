using Microsoft.EntityFrameworkCore;
using Web_Holistecc.Data;
using Web_Holistecc.Repository_s.CustomerRepo_s;
using Web_Holistecc.Repository_s.OrderRepo_s;
using Web_Holistecc.Repository_s.ProductRepo_s;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContextt>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("myconnk")));

builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IOrderRepo, OrderRepo>();
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
