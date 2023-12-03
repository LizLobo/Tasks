using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace Task2_HierarchicalStructure.Model
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname {  get; set; }

        public int Age { get; set; }
        public string Sex { get; set; }
        public string Gender { get; set; }
        public bool IsDeceased { get; set; }


        public List<Relationships>? Relationships { get; private set; }


    public Person(string id, string name, string surname, int age, string sex, string gender, bool isDeceased)
    {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
            Gender = gender;
            IsDeceased = isDeceased;
            Relationships = new List<Relationships>();
    }

        public void AddRelationship(Person relatedPerson, RelationshipType relationshipType)
        {
            Relationships.Add(new Relationships(relatedPerson, relationshipType));
        }


    }



   

}
