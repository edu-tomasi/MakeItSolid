using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeItSolid
{
    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }

    public class Person
    {
        public string Name;
    }

    public class RelationShips
    {
        private List<Tuple<Person, Relationship, Person>> relations = new List<Tuple<Person, Relationship, Person>>();

        public void AddParentAndChild(Person parent, Person child)
        {
            //relations.Add(Tuple<parent, Relationship.Parent, child>);
            //relations.Add(()
        }
    }
}
