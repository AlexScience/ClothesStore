using System.Text.Json;
using ClothesStore.Models.Models;

namespace ClothesStore.API.DAL;

public class ClientDataStorage : IDataStorage<Client>
{
    public string Path => "clients.txt";

    public void Save(Client obj)
    {
        var clients = GetClients().ToList();

        var found = clients.FirstOrDefault(c => c.Id == obj.Id);
        if (found != null)
        {
            clients.Remove(found);
        }

        clients.Add(obj);
        var serialized = JsonSerializer.Serialize(clients);
        WriteToFile(Path, serialized);
    }

    public Client Fetch(Guid id)
    {
        var clients = GetClients().ToList();
        var found = clients.FirstOrDefault(c => c.Id == id);
        return found ?? throw new InvalidOperationException("Клиент не найден");
    }

    public IEnumerable<Client> FetchAll()
    {
        return GetClients();
    }

    private IEnumerable<Client> GetClients()
    {
        List<Client> clients;
        var content = ReadFile(Path);
        if (string.IsNullOrEmpty(content))
        {
            clients = new List<Client>();
        }
        else
        {
            clients = JsonSerializer.Deserialize<List<Client>>(content) ?? new List<Client>();
        }

        return clients;
    }

    private string ReadFile(string path)
    {
        using var stream = File.Open(path, FileMode.OpenOrCreate, FileAccess.Read);
        var reader = new StreamReader(stream);
        var text = reader.ReadToEnd();
        return text;
    }

    private void WriteToFile(string path, string content)
    {
        using var stream = File.OpenWrite(path);
        using var writer = new StreamWriter(stream);
        writer.Write(content);
    }
}