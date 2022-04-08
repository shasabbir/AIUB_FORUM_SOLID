using System.Collections.Generic;

namespace DAL
{
    public interface IRepository<T, ID, STRING>
    {
        bool Add(T obj);
        T Get(ID id);
        List<T> Get();
        bool Edit(T obj);
        bool Delete(ID id);
        List<T> Search(STRING search);
    }
    public interface IRepository<T, ID>
    {
        bool Add(T obj);
        bool Edit(T u);
        bool Delete(ID id);
        T Get(ID id);
        List<T> Get();
    }
}