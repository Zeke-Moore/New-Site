using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Site.Models.Entities;

public interface IAPI<T> where T : Entity
{
    int Count { get; }
    bool HasChanges { get; }
    T Find(int? id);
    T GetFirst();
    IEnumerable<T> GetAll();
    IEnumerable<T> GetRange(int skip, int take);
    int Add(T entity, bool persist = true);
    int AddRange(IEnumerable<T> entities, bool persist = true);
    int Update(T entity, bool persist = true);
    int UpdateRange(IEnumerable<T> entities, bool persist = true);
    int Delete(T entity, bool persist = true);
    int DeleteRange(IEnumerable<T> entities, bool persist = true);
    int Delete(int id, byte[] timeStamp, bool persist = true);
    int SaveChanges();
}
