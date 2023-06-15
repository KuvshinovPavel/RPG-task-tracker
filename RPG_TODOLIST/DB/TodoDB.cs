using RPG_TODOLIST.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_TODOLIST.DB
{
    public class TodoDB
    {
        readonly SQLiteAsyncConnection _connection;
        public TodoDB(string connectionString)
        {
            _connection = new SQLiteAsyncConnection(connectionString);
            _connection.CreateTableAsync<Todo>().Wait();
        }

        public Task<List<Todo>> GetAll()
        {
            return _connection.Table<Todo>().ToListAsync();
        }

        public void AddTodo(Todo todo)
        {
            _connection.InsertAsync(todo).Wait();
            
        }
        public void DeleteTodo(Todo todo)
        {
            _connection.DeleteAsync(todo).Wait();
        }
    }
}
