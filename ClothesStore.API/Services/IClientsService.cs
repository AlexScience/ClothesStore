using ClothesStore.Models.Models;

namespace ClothesStore.API.Services;

public interface IClientsService
{
    public void CreateClient(Client client);
    public IEnumerable<Client> GetAllClients();
    public Client GetClientById(Guid clientId);
    
}