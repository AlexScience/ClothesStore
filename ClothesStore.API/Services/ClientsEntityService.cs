using ClothesStore.API.DAL;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Services;

public class ClientsEntityService : IEntityService<Client>
{
    private readonly IDataStorage<Client> _clientStorage;

    public ClientsEntityService(IDataStorage<Client> clientStorage)
    {
        _clientStorage = clientStorage;
    }

    public void Create(Client obj)
    {
        _clientStorage.Save(obj);
    }

    public IEnumerable<Client> GetAll()
    {
        return _clientStorage.FetchAll();
    }

    public Client GetById(Guid id)
    {
        return _clientStorage.Fetch(id);
    }
}