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
            //send it
            return db.GetToDoList();
        }
        [HttpGet("GetToDo/{id}")]
        public ToDoItem GetToDo(int id)
        {
            return db.GetToDoItem(id);
        }
        [HttpPost("CreateToDo")]
        public void CreateToDo(ToDoItem toInsert)
        {
            db.InsertToDoItem(toInsert);
        }
        [HttpPut("UpdateToDo")]
        public void UpdateToDo(ToDoItem toUpdate)
        {
            db.UpdateToDoItem(toUpdate);
        }
        [HttpDelete("DeleteToDo/{id}")]
        public void DeleteToDo(int id)
        {
            db.DeleteToDoItem(id);
        }
    }

}
