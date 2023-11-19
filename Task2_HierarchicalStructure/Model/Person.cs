using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2_HierarchicalStructure.Model
{
    public class Person
    {
        public string Name { get; set; }

        public int Id { get; set; }
        public List<Relationships>? Relationships { get; set; }



    }

   

}
