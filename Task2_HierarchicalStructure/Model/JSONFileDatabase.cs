using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_HierarchicalStructure.Model
{
    public class JSONFileDatabase
    {
        

        //@LIZ needs to be renamed.
        public void SaveAllPersonsToJsonFile(string jsonFilePath, List<Person> people)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(people, Formatting.Indented);
                File.WriteAllText(jsonFilePath, jsonData);
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                Console.WriteLine($"Error saving to JSON file: {ex.Message}");
            }
        }

        
        public List<Person> LoadAllPersonsFromJSONFile(string jsonFilePath)
        {
            List<Person> people = new List<Person>();
            try
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                people = JsonConvert.DeserializeObject<List<Person>>(jsonData);

                
            }
            catch (Exception ex)
            {

                throw new Exception("Failed to load person objects from JSONfile");
            }
            return people;
        }

       
        public void RemoveAPersonFromJsonFile(Person person, string jsonFilePath)
        {

            List<Person> existingData = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(jsonFilePath));


            existingData.RemoveAll(p => p.Id == person.Id);


            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(existingData, Formatting.Indented));
        }

    }
}
