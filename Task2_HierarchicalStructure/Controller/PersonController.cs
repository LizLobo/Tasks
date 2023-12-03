using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_HierarchicalStructure.Model;
using Task2_HierarchicalStructure.View;
using Newtonsoft.Json;
using System.Reflection;
using System.Windows.Forms;

namespace Task2_HierarchicalStructure.Controller
{
    public class PersonController
    {
        

        private PersonModel _personModel;
        
        public PersonController(PersonModel personModel) 
        {
            _personModel = personModel;
           
        }
        public void AddPerson(Person person)
        {
           _personModel.AddPerson(person);
        }

        public List<Person> GetPeopleList()
        {
            //After this runs there is one less person object in the PersonList --> Hence it doesn't get the PersonList in Memory.
            return _personModel.PersonList;
        }


        public bool RemovePerson(Person person)
        {
            return _personModel.RemovePerson(person);
        }


        
        

      
    }
}
