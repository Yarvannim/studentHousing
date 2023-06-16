using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentApp
{
    public class Tasks
    {
        public string TaskText { get; }
        public string SelectedDay { get; }
        public int TaskId { get; }
        public string StudentName { get; }
        public int StudentId { get; }
        public int TaskDone { get; }
        public string TaskDetail => $"Assigned student: {StudentName} | {TaskText} | {(TaskDone == 1 ? "Task done" : "Task not done")}";
        public Tasks(string taskText,int taskId, string selectedDay)
        {
            //Getting a task
            this.TaskText = taskText;
            TaskId = taskId;
            this.SelectedDay = selectedDay;
        }
        public Tasks(string taskText, string selectedDay)
        {
            //Saving the task on the admin side
            this.TaskText = taskText;
            this.SelectedDay = selectedDay;
            SaveTask(taskText,selectedDay);
        }
        public Tasks(string StudentName, string taskText, string Date, int taskDone, int studentId, int taskId)
        {
            //Getting tasks 
            this.StudentName = StudentName;
            this.TaskText = taskText;
            this.SelectedDay = Date;
            this.TaskDone = taskDone;
            this.StudentId = studentId;
            this.TaskId = taskId;
        }
        public void SaveTask(string taskText,string selectedDay)
        {
            Database.InsertTask(taskText, selectedDay);
        }

        public void DeleteTask(int taskID)
        {
            Database.DeleteTasks(taskID);
        }

        public static List<Tasks> GetAllTasks()
        {
            return Database.GetAllTasks();
        }

        public void AssignTask(int studentID, int taskID)
        {
            Database.AssignTask(studentID, taskID);
        }
        public override string ToString()
        {
            return TaskDetail;
        }
    }
}
