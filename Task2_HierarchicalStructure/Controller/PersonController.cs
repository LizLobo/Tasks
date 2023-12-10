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
        PersonModel personModel = PersonModel.GetInstance();


        public PersonController() 
        {
           
            
           
        }
        public void AddPerson(Person person)
        {
           personModel.AddPerson(person);
        }

        public List<Person> GetPeopleList()
        {
            return personModel.People;
        }


        public bool RemovePerson(Person person)
        {
            return personModel.RemovePerson(person);
        }

        
        
        

      
    }
}
