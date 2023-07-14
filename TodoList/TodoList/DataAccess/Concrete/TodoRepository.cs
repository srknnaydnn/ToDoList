using TodoList.DataAccess.Abstract;
using TodoList.Model;

namespace TodoList.DataAccess.Concrete
{
    public class TodoRepository: EntityRepository<TodoItem,AppDbContext>,ITodoRepository
    {
    }
}
