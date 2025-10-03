using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Services
{
    public interface ITodoService
    {
        IEnumerable<Todo> GetAll();
        Todo? GetById(int id);
        Todo Add(Todo todo);
        Todo? Update(int id, Todo todo);
        bool Delete(int id);
    }
}
