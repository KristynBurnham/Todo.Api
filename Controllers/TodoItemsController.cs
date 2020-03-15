using Microsoft.AspNetCore.Mvc;
using System;
using Todo.Api.Services;
using System.Collections.Generic;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoItemsController : ControllerBase
    {
        private ITodoRepository repository;
        public TodoItemsController(ITodoRepository todoRepository)
        { 
            repository = todoRepository ??
                throw new ArgumentNullException(nameof(todoRepository));
        }
        [HttpGet]
        public IActionResult GetTodos()
        {
            var result = repository.GetAllTodoItems();
            if (result = null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}