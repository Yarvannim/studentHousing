using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Rules
    {
        private int _id;

        public int ID
        {
            get { return _id; }
        }

        private string rule;

        public string Rule
        {
            get { return rule; }
        }


        public Rules(string rule)
        {
            AddRule(rule);
        }
        public Rules(string rule, int id)
        {
            this.rule = rule;
            this._id = id;
        }

        public void AddRule(string rule)
        {
            Database.InsertRule(rule);
        }

        public void RemoveRule(int id)
        {
            Database.DeleteRule(id);
        }


        public static List<Rules> GetAllRules()
        {
            return Database.GetAllRules();
        }
        public override string ToString()
        {
            return $"{rule}";
        }
    }
}
