using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneTaskList.Models
{
    public class TaskDAL
    {
        //ToDoItem CRUD
        public List<ToDoItem> GetToDoList()
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from tasks";
                connect.Open();
                List<ToDoItem> taskList = connect.Query<ToDoItem>(sql).ToList();
                connect.Close();
                return taskList;
            }
        }
        public ToDoItem GetToDoItem(int id)
        {
            string sql = $"select * from tasks where id={id}";
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                ToDoItem todo = connect.Query<ToDoItem>(sql).First();
                connect.Close();
                return todo;
            }
        }
        
        public void InsertToDoItem(ToDoItem td)
        {
            string sql = $"insert into tasks values(0,'{td.Tm}','{td.ShortDescription}','{td.DueDate}',{td.Completed})";
            using(var connect= new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<ToDoItem>(sql);
                connect.Close();
            }
        }
        public void UpdateToDoItem(ToDoItem td)
        {
            string sql = $"update tasks set tm='{td.Tm}',shortdescription='{td.ShortDescription}',due_date='{td.DueDate}',completed={td.Completed}";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<ToDoItem>(sql);
                connect.Close();
            }
        }
        public void DeleteToDoItem(int id)
        {
            string sql = $"delete from tasks where id={id}";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                connect.Query<ToDoItem>(sql);
                connect.Close();
            }
        }
    }
}
