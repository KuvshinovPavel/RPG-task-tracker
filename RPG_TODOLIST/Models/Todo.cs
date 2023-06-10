using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace RPG_TODOLIST.Models
{
    
    public class Todo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string TodoDescription { get; set; }
        public string Difficulty{ get; set; }
        public string DifficultyColor{ get; set; }
        public DateTime CompletionDate { get; set; }
    }
}
