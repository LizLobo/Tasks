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
            // Load existing data from the JSON file
            List<Person> existingData = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(jsonFilePath));

            // Remove the specified person
            existingData.RemoveAll(p => p.Id == person.Id); // Modify this based on your comparison logic

            // Serialize and save the updated data back to the JSON file
            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(existingData, Formatting.Indented));
        }




    }

}
