using Erpv1.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Erpv1.Repositories
{
   public class Repository<T> where T: class,new()
    {
        erpEntities db = new erpEntities();

        public List<T> All
        {
            get
            {
                return db.Set<T>().ToList();
            }
        }

        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }



        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void TUpdate(T p)
        {
            db.SaveChanges();
        }
        public T Find(Expression<Func<T, bool>> where)
        {

            return db.Set<T>().FirstOrDefault(where);
        }

        public List<T> GetListByID(Expression<Func<T, bool>> filter)
        {
            return db.Set<T>().Where(filter).ToList();
        }
    }
}
