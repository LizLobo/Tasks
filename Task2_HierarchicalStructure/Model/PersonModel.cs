using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task2_HierarchicalStructure.Model
{
   
        public class PersonModel
        {
        //Path for JSON file of person objects
        private string jsonFilePath = @"..\..\..\Data\JSONFamily.json";
            public List<Person> PersonList { get; private set; }

            public PersonModel()
            {
                PersonList = new List<Person>();
            }

           
            public void AddPerson(Person person)
            {
                PersonList.Add(person);
            }

        public void GetFamilyFromFile(string filePath)
        {

            try
            {

                string jsonData = System.IO.File.ReadAllText(filePath);

                PersonList = JsonConvert.DeserializeObject<List<Person>>(jsonData);
            }
            catch
            {

            }
            
        }

        

    }
    
}
