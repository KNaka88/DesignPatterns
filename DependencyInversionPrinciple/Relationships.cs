using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple
{
    public class Relationships : IRelationshipBrowser // low-level
    {
        // C# 7 tuple
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();
        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }


        // Bad Practice, high-level module shouldn't directly access to low-level module
        // dont't make public. this makes hard to change in the future

        //public List<(Person, Relationship, Person)> Relations => relations;

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations
                .Where(x => x.Item1.Name == name
                            && x.Item2 == Relationship.Parent)
                .Select(r => r.Item3);            
        }
    }
}