using System.Data;

namespace BusinessLayer.Interface
{
    interface IService<T>
    {
        bool Add(T item);
        bool Edit(T item);
        bool Delete(int id);
        T GetById(int id);
        DataTable GetAllPending();
    }
}