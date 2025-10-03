using DataAccess.Entities;
using DataAccess.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Todo_List.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {

        private readonly ITodoService _todoService;

        public ToDoController(ITodoService todoService)
        {
            _todoService = todoService;
        }


        [HttpGet]
        public IActionResult GetAll() => Ok(_todoService.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var todo = _todoService.GetById(id);
            return todo == null ? NotFound() : Ok(todo);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Todo todo)
        {
          var newToDo =   _todoService.Add(todo);
          return CreatedAtAction(nameof(GetById), new {id = newToDo.Id}, newToDo);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Todo todo)
        {
            var updated = _todoService.Update(id, todo);
            return updated == null ? NotFound() : Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return _todoService.Delete(id) ? NoContent() : NotFound();
        }

    }
}
