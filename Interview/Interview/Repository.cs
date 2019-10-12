using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Repository<T, I> : IRepository<T, I> where T : IStoreable<I>
    {
        private readonly List<T> _repository;
        public Repository()
        {
            _repository = new List<T>();
        }

        public void Delete(I id)
        {
            _repository.RemoveAll(new Predicate<T>(z => z.Id.Equals(id)));
        }
        public T Get(I id)
        {
            return _repository.Find(new Predicate<T>(z => z.Id.Equals(id)));
        }

        public IEnumerable<T> GetAll()
        {
            return _repository;
        }

        public void Save(T item)
        {
            _repository.Add(item);
        }
    }

}
