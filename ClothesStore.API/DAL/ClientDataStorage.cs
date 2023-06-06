using System.Text.Json;
using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL;

public class ClientDataStorage : FileDataStorage<Client>
{
    private const string Path = "client.txt";

    public ClientDataStorage() : base(Path)
    {
    }
}