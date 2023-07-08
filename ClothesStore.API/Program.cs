using ClothesStore.API.Controllers;
using ClothesStore.API.DAL;
using ClothesStore.API.DAL.FileStorage;
using ClothesStore.API.Services;
using ClothesStore.Models.Models;
using Microsoft.EntityFrameworkCore;

using DbClientsDataStorage = ClothesStore.API.DAL.DbStorage.ClientsDataStorage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<StoreDbContext>((opt) =>
{
     opt.UseNpgsql("Server=localhost;Port=54320;Database=postgres;User Id=postgres;Password=my_password");
});

builder.Services.AddScoped<IDataStorage<Client>, DbClientsDataStorage>();
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