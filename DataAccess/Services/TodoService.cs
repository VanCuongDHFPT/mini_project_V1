using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Services
{
    public class TodoService : ITodoService

    {
        private readonly List<Todo> _todos = new();

        private int _nextId = 1;

        public Todo Add(Todo todo)
        {
            todo.Id = ++_nextId;
            _todos.Add(todo);
            return todo;
        }

        public bool Delete(int id)
        {
            var exit = GetById(id);
            if (exit != null) 
            {
                _todos.Remove(exit);
                return true;
                
            }
            return false;

        }

        public IEnumerable<Todo> GetAll() => _todos;

        public Todo? GetById(int id) => _todos.FirstOrDefault(x => x.Id == id);

        public Todo? Update(int id, Todo todo)
        {
            try
            {
                var exit = GetById(id);
                if (exit != null)
                {
                    exit.Title = todo.Title;
                    exit.IsCompleted = todo.IsCompleted;
                    return exit;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
