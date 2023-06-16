using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentApp
{
    public class Database
    {
        private static readonly string connectionString = "Server=mssqlstud.fhict.local;Database=dbi523692;User Id=dbi523692;Password=qwerty8;";

        #region students
        public static void InsertStudent(string FirstName, string LastName, int StudenthouseID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Students (first_name, last_name, student_house_id) " +
                                   "VALUES (@FirstName, @LastName, @StudentHouse)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@StudentHouse", StudenthouseID);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Select * from Students";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int studentId = Convert.ToInt32(reader["student_id"]);
                                string firstName = Convert.ToString(reader["first_name"]);
                                string lastName = Convert.ToString(reader["last_name"]);
                                int studentHouse = Convert.ToInt32(reader["student_house_id"]);

                                Student student = new Student(studentId, firstName, lastName, studentHouse);
                                students.Add(student);
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return students;
        }

        public static Student GetStudentById(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Students WHERE student_id = @StudentId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = Convert.ToString(reader["first_name"]);
                                string lastName = Convert.ToString(reader["last_name"]);
                                int studentHouse = Convert.ToInt32(reader["student_house_id"]);

                                Student student = new Student(studentId, firstName, lastName, studentHouse);
                                return student;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            // Return null if the student is not found
            return null;
        }
        public static void DeleteStudent(int studentID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Delete from Students where student_id = @studentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        #endregion

        #region complaints

        public static void InsertComplaint(string Complaint, string title, int studentID = 0)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "";
                    connection.Open();
                    if (studentID == 0)
                    {
                        query = "INSERT INTO Complaints (complaint, date, complaint_title) " +
                                       "VALUES (@Complaint, @Date, @Title)";
                    }
                    else
                    {
                        query = "INSERT INTO Complaints (complaint, student_id, date, complaint_title) " +
                                       "VALUES (@Complaint, @StudentID, @Date, @Title)";
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Complaint", Complaint);
                        if (studentID != 0)
                        {
                            command.Parameters.AddWithValue("@StudentID", studentID);
                        }
                        DateTime date = DateTime.Now;
                        string sqlFormattedDate = date.ToString("yyyy-MM-dd");
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Title", title);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public static List<Complaints> GetAllComplaints()
        {
            List<Complaints> complaints = new List<Complaints>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Select * from complaints";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Complaints readerComplaint;
                                int complaintId = Convert.ToInt32(reader["complaint_id"]);
                                string complaintText = Convert.ToString(reader["complaint"]);
                                string complaintTitle = Convert.ToString(reader["complaint_title"]);
                                if (reader["student_id"] != null)
                                {
                                    int studentId = Convert.ToInt32(reader["complaint_id"]);
                                    readerComplaint = new Complaints(complaintText, studentId, complaintId, complaintTitle);
                                }
                                else
                                {
                                    readerComplaint = new Complaints(complaintText, complaintId, complaintTitle);
                                }
                                complaints.Add(readerComplaint);
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return complaints;
        }
        #endregion

        #region Agreements

        // returns a list of agreements
        public static List<Agreements> GetAllAgreements()
        {
            List<Agreements> agreements = new List<Agreements>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "select agreement_id, agreement, date, CONCAT(s.first_name, ' ',  s.last_name) as FullName , creator from Agreement A" +
                                   "inner join Students S on creator = S.student_id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int agreementID = Convert.ToInt32(reader["agreement_id"]);
                                string agreement = Convert.ToString(reader["agreement"]);
                                DateTime date = Convert.ToDateTime(reader["date"]);
                                int studentCreator = Convert.ToInt32(reader["creator"]);
                                string studentName = Convert.ToString(reader["FullName"]);

                                Agreements Readeragreement = new Agreements(agreementID, agreement, date, studentCreator, studentName);
                                agreements.Add(Readeragreement);
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return agreements;
        }

        public static void InsertAgreement(string Agreement, DateTime date, int studentID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int AgreementID;
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Agreement (agreement, date, creator) " +
                                   "VALUES (@Agreement, @Date, @Creator)";

                    string query2 = "SELECT TOP 1 agreement_id FROM Agreement " +
                                    "where creator = @Creator " +
                                    "ORDER BY agreement_id DESC";

                    string query3 = "INSERT INTO Agreements (student_id, agreement_id, vote)" +
                                    "VALUES (@Student, @AgreementID, @Vote)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Agreement", Agreement);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Creator", studentID);

                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@Creator", studentID);

                        AgreementID = Convert.ToInt32(command.ExecuteScalar());
                    }
                    using (SqlCommand command = new SqlCommand(query3, connection))
                    {
                        command.Parameters.AddWithValue("@Student", studentID);
                        command.Parameters.AddWithValue("@AgreementID", AgreementID);
                        command.Parameters.AddWithValue("@Vote", 1);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static void InsertOrUpdateVote(int agreementID, int studentID, int vote)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Agreements SET vote = @Vote " +
                                   "WHERE student_id = @Student and agreement_id = @AgreementID";

                    string query2 = "INSERT INTO Agreements (student_id, agreement_id, vote) " +
                                    "VALUES (@Student, @AgreementID, @Vote)";

                    string query3 = "SELECT TOP 1 * from Agreements " +
                                    "WHERE student_id = @Student and agreement_id = @AgreementID";

                    using (SqlCommand command = new SqlCommand(query3, connection))
                    {
                        command.Parameters.AddWithValue("@Student", studentID);
                        command.Parameters.AddWithValue("@AgreementID", agreementID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                using (SqlCommand command2 = new SqlCommand(query2, connection))
                                {
                                    command2.Parameters.AddWithValue("@Student", studentID);
                                    command2.Parameters.AddWithValue("@AgreementID", agreementID);
                                    command2.Parameters.AddWithValue("@Vote", vote);
                                    reader.Close();
                                    command2.ExecuteNonQuery();  // Execute the INSERT command
                                }
                            }
                            else
                            {
                                using (SqlCommand command1 = new SqlCommand(query, connection))
                                {
                                    command1.Parameters.AddWithValue("@Student", studentID);
                                    command1.Parameters.AddWithValue("@AgreementID", agreementID);
                                    command1.Parameters.AddWithValue("@Vote", vote);
                                    reader.Close();
                                    command1.ExecuteNonQuery();  // Execute the UPDATE command
                                }
                            }
                        }
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        // function that gets the yes and no votes per agreement
        public static Tuple<int, int> GetVotes(int agreementID)
        {
            int yesVotes = 0;
            int noVotes = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT
                                        SUM(CASE WHEN vote = 1 THEN 1 ELSE 0 END) AS YesVotes,
                                        SUM(CASE WHEN vote = 0 THEN 1 ELSE 0 END) AS NoVotes
                                    FROM Agreements
                                    WHERE agreement_id = @AgreementID
                                    GROUP BY agreement_id;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AgreementID", agreementID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                yesVotes = Convert.ToInt32(reader["YesVotes"]);
                                noVotes = Convert.ToInt32(reader["NoVotes"]);
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Tuple.Create(yesVotes, noVotes);
        }



        #endregion

        #region Rules
        // Insert a rule
        public static void InsertRule(string Rule)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Rules (rule_text)" +
                                   "VALUES (@Rule)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Rule", Rule);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        // delete a rule
        public static void DeleteRule(int RuleID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Delete from Students where rule_id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", RuleID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        // returns a list of all rules
        public static List<Rules> GetAllRules()
        {
            List<Rules> rules = new List<Rules>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Select * from Rules";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int rule_id = Convert.ToInt32(reader["rule_id"]);
                                string ruleText = Convert.ToString(reader["rule_text"]);

                                Rules rule = new Rules(ruleText, rule_id);
                                rules.Add(rule);
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return rules;
        }
        #endregion

        #region Tasks
        // insert a task
        public static void InsertTask(string TaskText,string selectedDay)
        {
            using (SqlConnection conn =  new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string querry = "INSERT INTO Tasks (task_text, date) " +
                        "VALUES (@TaskText, @selectedDay)";
                    using (SqlCommand cmd = new SqlCommand(querry, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaskText", TaskText);
                        cmd.Parameters.AddWithValue("@selectedDay", selectedDay);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        // returns a list of task of the day
        public static List<int> GetDailyTasks(string DayNextWeek)
        {
            List<int> Dailytasks = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string querry = "SELECT t.task_id FROM Tasks t " +
                        "where t.date between (select CAST(GETDATE() AS Date)) and @DayNextWeek " +
                        "ORDER BY task_id DESC";
                    using (SqlCommand cmd = new SqlCommand(querry, connection))
                    {
                        cmd.Parameters.AddWithValue("@DayNextWeek", DayNextWeek);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int TaskID = Convert.ToInt32(reader["task_id"]);
                                Dailytasks.Add(TaskID);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
                return Dailytasks;
            }
        }
        // return a list of every single task
        public static List<Tasks> GetAllTasks()
        {
            List<Tasks> tasks = new List<Tasks>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string querry = "SELECT MAX(task_id) AS task_id, task_text, MAX(date) AS date FROM Tasks GROUP BY task_text;";
                    using (SqlCommand cmd = new SqlCommand(querry, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string TaskText = Convert.ToString(reader["task_text"]);
                                int TaskID = Convert.ToInt32(reader["task_id"]);
                                string taskDay = Convert.ToString(reader["date"]);
                                Tasks task = new Tasks(TaskText,TaskID,taskDay);
                                tasks.Add(task);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            return tasks;
        }
        // assign a task to a student
        public static void AssignTask(int studentID, int TaskID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string querry = "INSERT INTO Assignments (task_id, student_id, Taskdone)" +
                        "VALUES (@TaskID, @StudentID, 0)";
                    using (SqlCommand cmd = new SqlCommand(querry, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaskID", TaskID);
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
        // returns a list of tasks for a student
        public static List<Tasks> GetStudentsTaskAssigned(string Date)
        {
            List<Tasks> tasks = new List<Tasks>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string querry = "SELECT CONCAT(s.first_name, ' ', s.last_name) AS FullName,T.task_text,T.date, A.TaskDone, A.student_id, A.task_id FROM Tasks T " +
                        "INNER JOIN Assignments A ON T.task_id=A.task_id " +
                        "INNER JOIN Students S ON S.student_id=A.student_id " +
                        "WHERE T.date = @Date";
                    using (SqlCommand cmd = new SqlCommand(querry,conn))
                    {
                        cmd.Parameters.AddWithValue("@Date", Date);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string AssigneeName = Convert.ToString(reader["FullName"]);
                                    string TaskText = Convert.ToString(reader["task_text"]);
                                    string TaskDate = Convert.ToString(reader["date"]);
                                    int TaskDone = Convert.ToInt32(reader["TaskDone"]);
                                    int StudentID = Convert.ToInt32(reader["student_id"]);
                                    int TaskID = Convert.ToInt32(reader["task_id"]);
                                    Tasks task = new Tasks(AssigneeName, TaskText, TaskDate, TaskDone, StudentID, TaskID);
                                    tasks.Add(task);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
                return tasks;
            }
        }
        // gets dates?
        public static List<string> GetAllDatesAssigned()
        {
            List<string> tasks = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string querry = "SELECT date FROM Tasks t " +
                        "INNER JOIN Assignments a ON t.task_id = a.task_id " +
                        "INNER JOIN Students S ON s.student_id = a.student_id";
                    using (SqlCommand cmd = new SqlCommand(querry, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    DateTime date = (DateTime)reader["date"];
                                    string TaskDate = date.ToString("dd-MM-yyyy");
                                    tasks.Add(TaskDate);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
                return tasks;
            }
        }
        // Delete a task
        public static void DeleteTasks(int TaskID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "Delete from Tasks where task_id = @TaskID \r\n" +
                        "Delete From Assignments where task_id = @TaskID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaskID", TaskID);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        // updates the status of a task
        public static void UpdateTaskStatus(int taskID, int studentID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Assignments SET TaskDone = 1" +
                                   "WHERE student_id = @Student and task_id = @TaskID";

                    using (SqlCommand command1 = new SqlCommand(query, connection))
                    {
                        command1.Parameters.AddWithValue("@Student", studentID);
                        command1.Parameters.AddWithValue("@TaskID", taskID);
                        command1.ExecuteNonQuery();  // Execute the UPDATE command
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        #endregion

        #region Users

        public static void InsertUser(string UserType, string username, string Password, int studentnumber = 0)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "";
                    connection.Open();
                    if (studentnumber == 0)
                    {
                        query = "INSERT INTO Users (type_of_user, user_name, password) " +
                                   "VALUES (@UserType, @Username, @Password)";
                    }
                    else
                    {
                        query = "INSERT INTO Users (type_of_user, user_name, password, student_id) " +
                                "VALUES (@UserType, @Username, @Password, @Student)";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserType", UserType);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", Password);
                        if (studentnumber != 0)
                        {
                            command.Parameters.AddWithValue("@Student", studentnumber);
                        }

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static Tuple<bool,string, int?> Login(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT TOP 1 student_id, type_of_user FROM Users " +
                                    "WHERE user_name = @Username AND password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int? studentNumber = reader["student_id"] as int?;
                                string userType = reader["type_of_user"].ToString();

                                if (!string.IsNullOrEmpty(userType))
                                {
                                    // Login successful
                                    return new Tuple<bool, string, int?>(true, userType, studentNumber);
                                }
                            }
                        }

                        // Login failed
                        return new Tuple<bool, string, int?>(false, "", null);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static List<User> GetAllUsers()
        {
            List<User> Users = new List<User>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Select * from Users";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int userID = Convert.ToInt32(reader["user_id"]);
                                string userType = Convert.ToString(reader["type_of_user"]);
                                string username = Convert.ToString(reader["user_name"]);
                                string password = Convert.ToString(reader["password"]);
                                int? student_id = reader["student_id"] == DBNull.Value ? null : Convert.ToInt32(reader["student_id"]);

                                User user = new User();
                                user.ID = userID;
                                user.Usertype = userType;
                                user.Username = username;
                                user.Password = password;
                                user.StudentID = student_id;
                                Users.Add(user);
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Users;
        }

        public static void DeleteUser(int userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Delete from Users where user_id = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", userID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        #endregion
    }
}