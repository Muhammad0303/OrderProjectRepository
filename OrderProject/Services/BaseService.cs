using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using OrderProject.Abstractions.Services;
using OrderProject.DataProvider;
using OrderProject.Models;

namespace OrderProject.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T: EntityBase
    {
        private readonly string _filePath;

        public BaseService(string filePath)
        {
            _filePath = filePath;
        }
        public void Add(T entity)
        {
         
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