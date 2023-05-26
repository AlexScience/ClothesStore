using ClothesStore.API.DAL;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Services;

public class ClientsServices : IClientsService
{
    private readonly IDataStorage<Client> _clientsStorage;

    public ClientsServices(IDataStorage<Client> clientsStorage)
    {
        _clientsStorage = clientsStorage;
    }

    public void CreateClient(Client client)
    {
        _clientsStorage.Save(client);
    }

    public IEnumerable<Client> GetAllClients()
    {
        return _clientsStorage.FetchAll();
    }
}