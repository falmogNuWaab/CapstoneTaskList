using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapstoneTaskList.Models;

namespace CapstoneTaskList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskListController : ControllerBase
    {
        TaskDAL db = new TaskDAL();
        [HttpGet]
        public List<TaskList> GetTasks()
        {
            return db.ListAllTasks();
        }
    }
}
