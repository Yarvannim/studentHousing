using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StudentApp
{
    public class Agreements
    {
        private int _agreementID;

        public int ID
        {
            get { return _agreementID; }
        }

        private string _agreement;
        public string Agreement
        {
            get { return _agreement; }
        }
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
        }
        private int _creatorID;

        public int CreatorID
        {
            get { return _creatorID; }
        }
        private string _studentName;

        public string StudentName
        {
            get { return _studentName; }
        }


        public Agreements()
        {
            // Has to be here else there is endless recursion for some reason??
        }
        // constructor for creating a new agreement
        public Agreements(string agreement, DateTime date, int creator)
        {
            _agreement = agreement;
            _date = date;
            _creatorID = creator;
            saveAgreement();
        }
        // constructor for getting the data from database
        public Agreements(int id, string agreement, DateTime date, int creator, string studentName)
        {
            _agreement = agreement;
            _date = date;
            _agreementID = id;
            _creatorID = creator;
            _studentName = studentName;
        }
        // save agreement to database function
        public void saveAgreement()
        {
            Database.InsertAgreement(Agreement, Date, CreatorID);
        }
        // function that returns all agreements from the database
        public static List<Agreements> GetAllAgreements()
        {
            return Database.GetAllAgreements();
        }
        // function to vote yes on an agreement
        public void voteYes(int votingStudentID)
        {
            Database.InsertOrUpdateVote(ID, votingStudentID, 1);
        }
        // function to vote no on an agreement
        public void voteNo(int votingStudentID)
        {
            Database.InsertOrUpdateVote(ID, votingStudentID, 0);
        }
        // function that gets 2 ints first one is the yes votes, second one is no votes
        public Tuple<int,int> getVotes()
        {
            return Database.GetVotes(ID);
        }
        // the override to make it looks nice in listboxes
        public override string ToString()
        {
            Tuple<int, int> votes = getVotes();
            return $"Agreement {DateOnly.FromDateTime(Date)}, by {StudentName} | Yes: {votes.Item1}, No: {votes.Item2}";
        }
    }
}
