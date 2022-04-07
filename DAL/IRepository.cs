using System.Collections.Generic;

namespace DAL
{
    public interface IRepository<T, ID>
    {
        bool Add(T obj);
        T Get(ID id);
        List<T> Get();
        bool Edit(T obj);
        bool Delete(ID id);
    }
}