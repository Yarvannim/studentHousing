using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class User
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}
		private string username;

		public string Username
		{
			get { return username; }
			set { username = value; }
		}
		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}
		private string usertype;

		public string Usertype
		{
			get { return usertype; }
			set { usertype = value; }
		}
		private int? studentID;

		public int? StudentID
		{
			get { return studentID; }
			set { studentID = value; }
		}
		public List<User> GetAllUsers()
		{
			return Database.GetAllUsers();
		}
        public override string ToString()
        {
			return $"{username} {usertype} {studentID}";
        }
		public void DeleteUser(int id)
		{
			Database.DeleteUser(id);
		}
    }
}
