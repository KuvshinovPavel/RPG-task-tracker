﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_TODOLIST.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string CurrentLivingPlace { get; set; }
        public int Savings{ get; set; }

        public int HP { get; set; }
        public int Determination { get; set; }
        public int Experience { get; set; }
        public string PlayerImagePath { get; set; }
        public string BackgroundImagePath { get; set; }
        
    }
}
