using RPG_TODOLIST.DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RPG_TODOLIST
{
    
    public partial class App : Application
    {
        static TodoDB todoDB;

        public static TodoDB TodoDB
        {
            get
            {
                if (todoDB == null)
                {
                    TodoDB = new TodoDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "todos.db"));
                    TodoDB.AddTodo(new Models.Todo { TodoDescription = "Доделать диплом", Difficulty = "Easy", CompletionDate = new DateTime(), DifficultyColor ="green" });
                    TodoDB.AddTodo(new Models.Todo {  TodoDescription = "Доделать диплом", Difficulty = "Easy", CompletionDate = new DateTime(), DifficultyColor = "green" });
                    TodoDB.AddTodo(new Models.Todo {  TodoDescription = "Доделать диплом", Difficulty = "Normal", CompletionDate = new DateTime(), DifficultyColor = "yellow" });
                    TodoDB.AddTodo(new Models.Todo {  TodoDescription = "Доделать диплом", Difficulty = "HArd", CompletionDate = new DateTime(), DifficultyColor = "red" });
                    TodoDB.AddTodo(new Models.Todo {  TodoDescription = "Доделать диплом", Difficulty = "Hard", CompletionDate = new DateTime(), DifficultyColor = "red" });
                }
                return todoDB;
            }
            set { todoDB = value; }
        }
    }
}
