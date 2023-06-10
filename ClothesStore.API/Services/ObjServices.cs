using ClothesStore.API.DAL;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Services;

public class ObjServices<T> :IServices<T>
    where T : IEntity
{
    private readonly IDataStorage<T> _objStorage;

    public ObjServices(IDataStorage<T> objStorage)
    {
        _objStorage = objStorage;
    }

    public void CreateObj(T obj)
    {
        _objStorage.Save(obj);
    }

    public IEnumerable<T> GetAllObj()
    {
        return _objStorage.FetchAll();
    }

    public T GetObjById(Guid objId)
    {
        return _objStorage.Fetch(objId);
    }
}