using System.Linq.Expressions;

namespace TodoList.DataAccess.Abstract
{
   
        public interface IEntitiyRepository<T> where T : class
        {
            List<T> GetAll(Expression<Func<T, bool>> filter = null);
            T Get(Expression<Func<T, bool>> filter);
            void Add(T entitiy);
            void Delete(T entitiy);
            void Update(T entitiy);

        }
    
}
