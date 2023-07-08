using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL.DbStorage;

public class ClientsDataStorage : IDataStorage<Client>
{
    private readonly StoreDbContext _context;

    public ClientsDataStorage(StoreDbContext context)
    {
        _context = context;
    }

    public void Save(Client obj)
    {
        _context.Clients.Add(obj);
        _context.SaveChanges();
    }

    public Client? Fetch(Guid id)
    {
        return _context.Clients.FirstOrDefault(c => c.Id.Equals(id));
    }

    public IEnumerable<Client> FetchAll()
    {
        return _context.Clients.ToList();
    }
}