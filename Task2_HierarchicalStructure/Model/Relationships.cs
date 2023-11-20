using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_HierarchicalStructure.Model
{
    public class Relationships
    {
        public Person Person { get; set; }
   
        public RelationshipType Type { get; set; }

    }

    public enum RelationshipType
    {
        Father,
        Mother,
        Child,
        Sibling,
        Partner,
        Nephew
    }
}
