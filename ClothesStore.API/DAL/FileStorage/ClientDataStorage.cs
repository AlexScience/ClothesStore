using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL.FileStorage;

public class ClientDataStorage : FileDataStorage<Client>
{
    private const string Path = "client.txt";

    public ClientDataStorage() : base(Path)
    {
    }
}