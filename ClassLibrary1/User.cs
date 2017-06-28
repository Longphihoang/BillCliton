using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillClitonCommon
{
    class User
    {
        public List<Relationship> relationships;
        public string name;
        public double owe { get; set; }
        //contact info maybe?


        public User(string name)
        {
            this.name = name;
            relationships = new List<Relationship>();
        }

        public void addRelation(Relationship relation)
        {
            relationships.Add(relation);
            relationships.Sort();
        }
    }
}
