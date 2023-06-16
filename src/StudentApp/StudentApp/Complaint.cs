using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Complaints
    {
        private string complaint;
        private int complainingStudent;
        private int complaintid;
        public string Complaint 
        { 
            get {return complaint;} 
        }
        public int Complaintid
        {
            get { return complaintid;}
        }

        private string complaintTitle;

        public string ComplaintTitle
        {
            get { return complaintTitle; }
            set { complaintTitle = value; }
        }


        public Complaints(string complaintMessage, Student student, string complaintTitle)
        {
            //CREATE A NEW COMPLAINT NOT ANONYMOUSLY
            this.complaint = complaintMessage;
            this.complainingStudent = student.StudentID;
            this.complaintTitle = complaintTitle;
            SaveComplaint();
        }
        public Complaints(string complaintMessage, string complaintTitle)
        {
            //CREATE A NEW COMPLAINT ANONYMOUSLY
            this.complaint = complaintMessage;
            this.complaintTitle = complaintTitle;
            SaveComplaintAnonymously();
        }
        public Complaints(string complaintMessage, int studentID, int id, string complaintTitle)
        {
            //FOR GETTING THE NON ANONYMOUS FROM DATABASE
            this.complaint = complaintMessage;
            this.complainingStudent = studentID;
            this.complaintid = id;
            this.complaintTitle = complaintTitle;
        }
        public Complaints(string complaintMessage, int id, string complaintTitle)
        {
            //FOR GETTING THE ANONYMOUS FROM DATABASE
            this.complaint = complaintMessage;
            this.complaintid = id;
            this.complaintTitle = complaintTitle;
        }
        // save complaint to database
        public void SaveComplaint()
        {
            Database.InsertComplaint(this.Complaint,this.complaintTitle, complainingStudent);
        }
        // save complaint but anonymously
        public void SaveComplaintAnonymously()
        {
            Database.InsertComplaint(this.Complaint, this.complaintTitle);
        }
        // function that returns a list of all complaints from the database
        public static List<Complaints> GetAllComplaints()
        {
            return Database.GetAllComplaints();
        }
        // function that makes it look nice in listboxes
        public override string ToString()
        {
            return complaintTitle;
        }
    }
}
