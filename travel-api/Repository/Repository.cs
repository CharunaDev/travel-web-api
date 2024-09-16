using Microsoft.EntityFrameworkCore;
using travel_api.Data;
using travel_api.Interfaces;
using travel_api.Models;

namespace travel_api.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly APIContext _context;
        private DbSet<T> entities;
        
        public Repository(APIContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }

        public T Get(int Id)
        {
            return entities.SingleOrDefault(c => c.Id == Id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T Insert(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.CreateDate = DateTime.Now;
            entity.UpdatedDate = DateTime.Now;
            entities.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public IEnumerable<T> InsertList(IEnumerable<T> entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.AddRange(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Remove(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.UpdatedDate = DateTime.Now;
            entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
