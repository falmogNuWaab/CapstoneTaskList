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
        public List<ToDoItem> GetToDoItemsByTmId(int tmId)
        {
            string sql = $"select * from tasks where tmid={tmId}";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<ToDoItem> assignmentList = connect.Query<ToDoItem>(sql).ToList();
                connect.Close();
                return assignmentList;
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
        
        public List<TeamMember> GetTeamMembers()
        {
            string sql = "select * from teammembers";
            using (var connect = new MySqlConnection(Secret.Connection))
            {                
                connect.Open();
                List<TeamMember> tmList = connect.Query<TeamMember>(sql).ToList();
                connect.Close();
                return tmList;
            }
        }
        public TeamMember GetTeamMember(int id)
        {
            string sql = $"select * from teammembers where id={id}";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                TeamMember tm = connect.Query<TeamMember>(sql).First();
                connect.Close();
                return tm;
            }
        }

        public List<TmToDo> GetAssignments()
        {
            string sql = "select * from tmtodos";
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<TmToDo> assignmentList = connect.Query<TmToDo>(sql).ToList();
                connect.Close();
                return assignmentList;
            }
        }
        public List<TmToDo> GetAssignmentByTmId(int tmId)
        {
            string sql = $"select * from tomtodos where tmid={tmId}";
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                connect.Open();
                List<TmToDo> assignmentList = connect.Query<TmToDo>(sql).ToList();
                connect.Close();
                return assignmentList;
            }
        }
    }
}
