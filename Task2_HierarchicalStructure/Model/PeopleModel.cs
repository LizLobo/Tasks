using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_HierarchicalStructure.Model
{
   
        public class PeopleModel
        {
            public List<Person> PeopleList { get; set; }

            public PeopleModel()
            {
                PeopleList = new List<Person>();
            }

            public void AddPerson(Person person)
            {
                PeopleList.Add(person);
            }

        }
    
}
