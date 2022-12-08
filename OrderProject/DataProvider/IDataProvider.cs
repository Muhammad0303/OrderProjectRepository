using OrderProject.Models;

namespace OrderProject.DataProvider
{
    public interface IDataProvider<T> where T: EntityBase
    {
        void Add(T entity);
        void Delete(T entity);
        T GetById(long id);
        void Update(T entity);
    }
}