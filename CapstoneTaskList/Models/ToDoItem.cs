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
        public int TmId { get; set; }
        public string ShortDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }

        public ToDoItem(int id, int tmId, string shortDescription, DateTime dueDate, bool completed)
        {
            Id = id;
            TmId = tmId;
            ShortDescription = shortDescription;
            DueDate = dueDate;
            Completed = completed;
        }
        public ToDoItem()
        {

        }
    }
}
