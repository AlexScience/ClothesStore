﻿using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL;

public class WarehouseDataStorage : FileDataStorage<Warehouse>
{
    private const string Path = "warehouse.txt";
    
    protected WarehouseDataStorage() : base(Path)
    {
    }
}