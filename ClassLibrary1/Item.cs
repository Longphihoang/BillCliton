using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillClitonCommon
{
    class Item
    {
        public string name { get; set; }
        public double price { get; set; }
        public List<Relationship> relationships;


        public Item(String name, double price)
        {
            this.name = name;
            this.price = price;
            relationships = new List<Relationship>();
        }

        public void addRelation(Relationship relation)
        {
            relationships.Add(relation);
            //relationships.Sort();
        }

        public void removeRelation(Item item)
        {
            
        }
    }
}
