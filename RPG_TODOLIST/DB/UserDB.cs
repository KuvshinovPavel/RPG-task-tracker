﻿using RPG_TODOLIST.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_TODOLIST.DB
{
    public class UserDB
    {
        readonly SQLiteAsyncConnection _connection;
        public UserDB(string connectionString)
        {
            _connection = new SQLiteAsyncConnection(connectionString);
            _connection.CreateTableAsync<User>().Wait();
        }

        public User GetUser() => _connection.QueryAsync<User>("select * from User", 0).Result.FirstOrDefault();
        public void AuthorizeUser(User user)
        {
            _connection.InsertAsync(user).Wait();
        }
    }
}
