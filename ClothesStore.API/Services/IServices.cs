using ClothesStore.Models.Models;

namespace ClothesStore.API.Services;

public interface IServices<T>
{
    public void CreateObj(T obj);
    public IEnumerable<T> GetAllObj();
    public T GetObjById(Guid objId);
}