using System.Collections.Generic;

namespace DAL
{
    public interface IRepository<T, TId, TString>
    {
        bool Add(T obj);
        T Get(TId id);
        List<T> Get();
        bool Edit(T obj);
        bool Delete(TId id);
        List<T> Search(TString search);
    }
    public interface IRepository<T, TId>
    {
        bool Add(T obj);
        bool Edit(T u);
        bool Delete(TId id);
        T Get(TId id);
        List<T> Get();
    }
}