using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.DAL
{
    public class BaseDAL<T> : IBaseDAL<T> where T : class
    {
        private QLBHEntities _entities;

        public BaseDAL()
        {
            _entities = new QLBHEntities();
        }
        public T Add(T entity)
        {
                var result = _entities.Set<T>().Add(entity);
                _entities.SaveChanges();
                return result;
        }

        public void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
            _entities.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _entities.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
            _entities.SaveChanges();
        }
    }
}
