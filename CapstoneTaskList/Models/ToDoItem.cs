using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneTaskList.Models
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }
        public string Tm { get; set; }
        public string ShortDescription { get; set; }
        public string DueDate { get; set; }
        public bool Completed { get; set; }

        public ToDoItem(int id, string tm, string shortDescription, string dueDate, bool completed)
        {
            Id = id;
            Tm = tm;
            ShortDescription = shortDescription;
            DueDate = dueDate;
            Completed = completed;
        }
        public ToDoItem()
        {

        }
    }
}
