using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneTaskList.Models
{
    public class TaskList
    {
        public int Id { get; set; }
        public string TmName { get; set; }
        public string ShortDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }

        public TaskList(int id, string tmName, string shortDescription, DateTime dueDate, bool completed)
        {
            Id = id;
            TmName = tmName;
            ShortDescription = shortDescription;
            DueDate = dueDate;
            Completed = completed;
        }
        public TaskList()
        {

        }
    }
}
