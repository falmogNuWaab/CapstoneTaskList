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
        public List<TaskList> ListAllTasks()
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from tasks";
                connect.Open();
                List<TaskList> taskList = connect.Query<TaskList>(sql).ToList();
                connect.Close();
                return taskList;
            }
        }
    }
}
