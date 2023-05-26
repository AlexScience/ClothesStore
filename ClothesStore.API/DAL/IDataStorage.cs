namespace ClothesStore.API.DAL;

public interface IDataStorage<T>
{
    public string Path { get; }
    public void Save(T obj);
    public T Fetch(Guid id);

    public IEnumerable<T> FetchAll();
}