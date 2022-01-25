using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneTaskList.Models
{
    public class TmToDo
    {
        [Key]
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int TmId { get; set; }
        public DateTime AssingedDate { get; set; }
    }
}
