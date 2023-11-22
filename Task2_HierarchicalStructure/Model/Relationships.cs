using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_HierarchicalStructure.Model
{
    public class Relationships
    {
        public Person RelatedPerson { get; set; }
        public int RelatedPersonID { get; }
   
        public RelationshipType Type { get; }

    public Relationships( Person relatedPerson, int relatedPersonID, RelationshipType type)
    {
        RelatedPerson = relatedPerson;
        RelatedPersonID = relatedPersonID;
        Type = type;
    }

       
    }


    public enum RelationshipType
    {
        Parent,
        Child,
        Sibling,
        Partner
        
    }
}
