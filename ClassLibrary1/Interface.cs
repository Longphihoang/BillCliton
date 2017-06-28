using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillClitonCommon
{
    class Interface
    {
        public static List<Relationship> relationships;
        public static List<User> users;
        public static List<Item> items;

        //maybe a unique id?
       public Interface()
        {
            users = new List<User>();
            items = new List<Item>();
            relationships = new List<Relationship>();
        }


        public static void addItem(String name, double price)
        {
            Item item = new Item(name, price);
            items.Add(item);
        }

        public static void addUser(String name)
        {
            User user = new User(name);
            users.Add(user);
        }

        public static bool addRelationship(User user, Item item)
        {
            for(int i = 0; i<item.relationships.Count;i++)
            {
                if(item.relationships[i].checkUser(user.name))
                {
                    return false;
                }
        
            }
            
            Relationship relation = new Relationship(user, item);
            relationships.Add(relation);
            user.addRelation(relation);
            item.addRelation(relation);
            return true;
        }

        public static bool removeRelationship(User user, Item item)
        {
            Relationship relation;
            for(int i = 0; i< item.relationships.Count;i++)
            {
                if(item.relationships[i].checkUser(user.name))
                {
                    relation = item.relationships[i];
                    item.relationships.Remove(relation);
                    user.relationships.Remove(relation);
                    relationships.Remove(relation);
                }
            }

            //recalculate
            return true;
        }



        
    }
}
