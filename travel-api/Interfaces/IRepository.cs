using travel_api.Models;

namespace travel_api.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
        T Insert(T entity);
        void Update(T entity);
        void Remove(T entity);
        void SaveChanges();
        IEnumerable<T> InsertList(IEnumerable<T> entity);
    }
}
