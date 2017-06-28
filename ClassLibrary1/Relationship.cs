using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillClitonCommon
{
    class Relationship
    {
        public string name { get; set; }
        public double price { get; set; }
        public double split=1;
        private Item item { get; set; }
        private User user { get; set; }
        public static int nonce;
        private int uniqueId { get; }

        public Relationship(User user, Item item)
            {
            uniqueId = nonce;
            nonce++;
            this.item = item;
            this.user = user;
        }
        
        public bool checkItem(string name)
        {
            if(name == item.name)
            {
                return true;
            }
            return false;
        }

        public bool checkUser(string name)
        {
            if(user.name==name)
            {
                return true;
            }
            return false;
        }

        
       
    }
}
