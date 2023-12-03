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
            GetPersonsFromJSONFile(jsonFilePath);
        }

           
            public void AddPerson(Person person)
            {
                PersonList.Add(person);
                SavePersonsToJsonFile();
            }

        public bool RemovePerson(Person person)
        {

            return PersonList.Remove(person);    

        }

        public void AddRelationship(Person mainPerson, Person relatedPerson, RelationshipType relationshipType)
        {
            if (relationshipType == RelationshipType.Parent)
            {
                bool isChild = relatedPerson.Relationships.Any(r => r.Type == RelationshipType.Child && r.RelatedPerson == mainPerson);

                if (isChild)
                {
                    MessageBox.Show("Cannot add parent relationship if already a child.");
                }
            }

            Relationships newRelationship = new Relationships(relatedPerson, relationshipType);

            mainPerson.AddRelationship(relatedPerson, relationshipType);


        }

        public void SavePersonsToJsonFile()
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(PersonList, Formatting.Indented);
                File.WriteAllText(jsonFilePath, jsonData);
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                Console.WriteLine($"Error saving to JSON file: {ex.Message}");
            }
        }
        public void GetPersonsFromJSONFile(string filePath)
        {
            try
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                PersonList = JsonConvert.DeserializeObject<List<Person>>(jsonData);

                if (PersonList == null)
                {
                    PersonList = new List<Person>();
                }
            }
            catch (Exception ex)
            {
               
                PersonList = new List<Person>();
            }
        }

        public void RemovePersonFromJsonFile(Person person)
        {
           
            List<Person> existingData = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(jsonFilePath));

          
            existingData.RemoveAll(p => p.Id == person.Id); 

            
            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(existingData, Formatting.Indented));
        }




    }

}
