using TodoList.Business.Abstract;
using TodoList.DataAccess.Abstract;
using TodoList.Helper.Result;
using TodoList.Model;
using TodoList.Model.Dto;

namespace TodoList.Business.Concrete
{
    public class TodoManager : ITodoService
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IUserService _userService;
        public TodoManager(ITodoRepository todoRepository,IUserService userService)
        {
                _todoRepository = todoRepository;
                _userService= userService;
        }
        public Result Add(TodoItemForAdd todo)
        {
            var todoItem = new TodoItem
            {
                TodoTitle = todo.TodoTitle,
                TodoDescription = todo.TodoDescription,
                Status = todo.Status,
                UserId = todo.UserId
            };
             _todoRepository.Add(todoItem);

            return new SuccessResult("Ekleme İşlemi Başarılı"); 
        }

        public DataResult<List<TodoItem>> TodoList()
        {
            var todoItem = _todoRepository.GetAll();
            
            return new SuccesDataResult<List<TodoItem>>(todoItem,"Listeleme İşlemi Başarılı");
        }

        public Result Update(TodoItemForUpdate todo)
        {


            var getTodo = _todoRepository.Get(x=>x.Id==todo.Id);

            if (todo.UserId == getTodo.UserId) 
            {

                getTodo.TodoTitle = todo.TodoTitle;
                getTodo.TodoDescription = todo.TodoDescription;
                getTodo.Status = todo.Status;
                
                _todoRepository.Update(getTodo);
                return new SuccessResult("Güncelleme İşlemi Başarılı");
            }
            return new SuccessResult("Güncellemek İstediğiniz To-Do Size Ait Değil");
        }
    }
}
