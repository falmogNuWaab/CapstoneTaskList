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
    public class ToDoListController : ControllerBase
    {
        TaskDAL db = new TaskDAL();
        [HttpGet]
        public List<ToDoItem> GetTasks()
        {
            return db.GetToDoList();
        }
        [HttpGet("TeamMembers")]
        public List<TeamMember> GetTeamMembers()
        {
            return db.GetTeamMembers();
        }
    }

}
