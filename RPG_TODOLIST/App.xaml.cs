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
        public static TodoDB todoDB;
        public static UserDB userDB;

        public static TodoDB TodoDB
        {
            get
            {
                if (todoDB == null)
                {
                    TodoDB = new TodoDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "todos.db"));
                 
                }
                return todoDB;
            }
            set { todoDB = value; }
        }

        public static UserDB UserDB {
            get {
            if (userDB == null)
                {
                    UserDB = new UserDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "user.db"));
                }
            return userDB;
            }
            set { userDB = value; } 
        }
    }
}
