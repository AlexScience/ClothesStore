using ClothesStore.API.Controllers;
using ClothesStore.API.DAL;
using ClothesStore.API.Services;
using ClothesStore.Models.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// builder.Services.AddDbContext<StoreDbContext>((opt) =>
// {
//     opt.UseSqlServer("Server=localhost,1433;Database=Clients;User=sa;Password=qwe1234qwe1234");
// });

builder.Services.AddScoped<IDataStorage<Client>, ClientDataStorage>();
builder.Services.AddScoped<IEntityService<Client>, ClientsEntityService>();

builder.Services.AddScoped<IDataStorage<ProductItem>, ProductItemDataStorage>();
builder.Services.AddScoped<IEntityService<ProductItem>, ProductEntityService>();

builder.Services.AddScoped<IDataStorage<Order>, OrderDataStorage>();
builder.Services.AddScoped<IEntityService<Order>, OrderEntityService>();

builder.Services.AddScoped<IDataStorage<Shipment>, ShipmentDataStorage>();
builder.Services.AddScoped<IEntityService<Shipment>, ShipmentEntityService>();

builder.Services.AddScoped<IDataStorage<Warehouse>, WarehouseDataStorage>();
builder.Services.AddScoped<IEntityService<Warehouse>, WarehouseEntityService>();


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