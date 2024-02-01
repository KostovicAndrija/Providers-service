using Library.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        public T GetById(long id);

        public T Add(T entity);

        public T Update(T entity);

        public void Delete(long id);

        public IEnumerable<T> GetAll();
    }
}
