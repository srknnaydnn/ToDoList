using TodoList.Helper.Result;
using TodoList.Model;
using TodoList.Model.Dto;

namespace TodoList.Business.Abstract
{
    public interface ITodoService
    {
        Result Add(TodoItemForAdd todo);
        Result Update(TodoItemForUpdate todo);
        DataResult<List<TodoItem>> TodoList();
    }
}
