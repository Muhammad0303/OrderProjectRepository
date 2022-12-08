using OrderProject.Models;

namespace OrderProject.DataProvider
{
    public class DatabaseDataProvider<T>: IDataProvider<T> where T: EntityBase
    {
        public void Add(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T customer)
        {
            throw new System.NotImplementedException();
        }
    }
}