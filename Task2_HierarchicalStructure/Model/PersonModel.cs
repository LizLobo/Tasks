﻿using System;
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
                SavePersonsToJsonFile();
            }

        public bool RemovePerson(Person person)
        {
            try
            {
                return PersonList.Remove(person);
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                Console.WriteLine($"Error removing person: {ex.Message}");
                return false;
            }

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
        public void GetPersonsFromFile(string filePath)
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
