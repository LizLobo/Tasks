using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_HierarchicalStructure.Model;
using Task2_HierarchicalStructure.View;
using Newtonsoft.Json;

namespace Task2_HierarchicalStructure.Controller
{
    public class PersonController
    {

        private PeopleModel _peopleModel;
        private PersonView _personView;
        public PersonController(PeopleModel peopleModel, PersonView personView) 
        {
            _peopleModel = peopleModel;
            _personView = personView;
        }
        public void AddPerson(Person person)
        {
           _peopleModel.AddPerson(person);
        }


        public static void RemovePerson(Person person)
        {
           // persons.Remove(person);
        }

        public void GetFamilyFromFile(string filePath)
        {
            string jsonData = System.IO.File.ReadAllText(filePath);

            var data = JsonConvert.DeserializeObject<PeopleModel>(jsonData);
        }
    }
}
