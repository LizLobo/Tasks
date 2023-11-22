using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_HierarchicalStructure.Model
{
    public class RelationshipManager
    {
        private Dictionary<Person, List<Person>> parentRelationships;
        private Dictionary<Person, List<Person>> childRelationships;
        private Dictionary<Person, List<Person>> siblingRelationships;
        private Dictionary<Person, Person> partnerRelationships;

        public RelationshipManager()
        {
            parentRelationships = new Dictionary<Person, List<Person>>();
            childRelationships = new Dictionary<Person, List<Person>>();
            siblingRelationships = new Dictionary<Person, List<Person>>();
            partnerRelationships = new Dictionary<Person, Person>();

        }

        public void AddParentRelationship(Person person, Person parent)
        {
            if (!parentRelationships.ContainsKey(person))
            {
                parentRelationships[person] = new List<Person>();
            }
            parentRelationships[person].Add(person);
        }
        public void AddChildRelationship(Person person, Person child)
        {
            if (!childRelationships.ContainsKey(person))
            {
                childRelationships[person] = new List<Person>();
            }

            childRelationships[person].Add(child);
        }

        public void AddSiblingRelationship(Person person, Person sibling)
        {
            if (!siblingRelationships.ContainsKey(person))
            {
                siblingRelationships[person] = new List<Person>();
            }

            siblingRelationships[person].Add(sibling);
        }

        public void AddPartnerRelationship(Person person, Person partner)
        {
            partnerRelationships[person] = partner;
            partnerRelationships[partner] = person;
        }

        public List<Person> GetParents(Person person)
        {
            if (parentRelationships.ContainsKey(person))
            {
                return parentRelationships[person];
            }
            return new List<Person>();
        }

        public List<Person> GetChildren(Person person)
        {
            if (childRelationships.ContainsKey(person))
            {
                return childRelationships[person];
            }
            return new List<Person>();
        }

        public List<Person> GetSiblings(Person person)
        {
            if (siblingRelationships.ContainsKey(person))
            {
                return siblingRelationships[person];
            }
            return new List<Person>();
        }

        public Person GetPartner(Person person)
        {
            if (partnerRelationships.ContainsKey(person))
            {
                return partnerRelationships[person];
            }
            return null;
        }
    }
}
