using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentApp
{
    public class Student
    {
        private int studentId;

        public int StudentID
        {
            get { return studentId; }
        }


        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
        }
        private int _studentHouseID;

        public int StudentHouseID
        {
            get { return _studentHouseID; }
        }

        public Student()
        {
            //TODO: Find out why this overload is here
        }
        public Student(string firstName, string lastName, int studentHouse)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._studentHouseID = studentHouse;
            saveStudent();
        }
        public Student(int studentID, string firstName, string lastName, int studentHouse)
        {
            this.studentId = studentID;
            this._firstName = firstName;
            this._lastName = lastName;
            this._studentHouseID = studentHouse;
        }
        public override string ToString()
        {
            return $"{_firstName} {_lastName}";
        }
        public void saveStudent()
        {
            Database.InsertStudent(FirstName, LastName, StudentHouseID);
        }

        public static List<Student> GetAllStudents()
        {
            return Database.GetAllStudents();
        }
        public static void deleteStudent(int StudentID)
        {
            Database.DeleteStudent(StudentID);
        }

        public string getName()
        {
            return $"{this._firstName} {this._lastName}";
        }

        public int getHouse()
        {
            return this._studentHouseID;
        }

    }
}
