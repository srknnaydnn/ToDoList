using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TodoList.Business.Abstract;
using TodoList.Model;
using TodoList.Model.Dto;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [Authorize]
        [HttpGet("todolist")]
        public IActionResult TodoList()
        {

            var todoList = _todoService.TodoList();
            if (todoList.Success)
            {
                return Ok(todoList);
            }
            return BadRequest();

        }

        [Authorize]
        [HttpPost("addtodo")]
        public IActionResult AddTodo(TodoItemForAdd todoItem)
        {

            var todo = _todoService.Add(todoItem);
            if (!todo.Success)
            {
                return BadRequest();
            }
            return Ok(todo.Message);
        }

        [Authorize]
        [HttpPost("updatetodo")]
        public IActionResult UpdateTodo(TodoItemForUpdate todoItem)
        {
            var todo = _todoService.Update(todoItem);
            if (!todo.Success)
            {
                return BadRequest();
            }
            return Ok(todo);

        }
    }
}
