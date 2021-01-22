using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        int Insert(T entity);
        int Update(T entity);
        int Delete(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
