using System.Data;

namespace Database.Repository
{
    public interface IRepository<T>
    {
        bool Add(T item);
        bool Edit(T item);
        bool Delete(int id);
        T GetById(int id);
        DataTable GetAll();
    }
}