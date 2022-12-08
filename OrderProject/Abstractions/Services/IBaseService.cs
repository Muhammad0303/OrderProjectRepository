using OrderProject.Models;

namespace OrderProject.Abstractions.Services
{
    public interface IBaseService<T> where T: EntityBase
    {
        void Add(T entity);
        void Delete(T entity);
        T GetById(long id);
        void Update(T customer);
    }
}