using TodoList.Model;

namespace TodoList.DataAccess.Abstract
{
    public interface ITodoRepository:IEntitiyRepository<TodoItem>
    {
    }
}
