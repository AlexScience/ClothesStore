namespace ClothesStore.API.Services;

public interface IEntityService<T>
{
    public void Create(T obj);
    public IEnumerable<T> GetAll();
    public T GetById(Guid id);
}