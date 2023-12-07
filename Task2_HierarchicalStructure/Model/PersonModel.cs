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
            private static PersonModel instance;
            private JSONFileDatabase jsonFileDatabase = new JSONFileDatabase();
            public List<Person> People { get; private set; }



            private PersonModel(string jsonFilePath)
            {
            People = jsonFileDatabase.LoadAllPersonsFromJSONFile(jsonFilePath);
            }

        //Create a single instance of People list to be used across the whole application:
        // Using Singleton Pattern

        public static PersonModel GetInstance(string jsonFilePath) 
        {
            if (instance == null)
            {
                instance = new PersonModel(jsonFilePath);
            }
            return instance;
        }

           
            public void AddPerson(Person person)
            {
                People.Add(person);
                SaveAPersonToJsonFile();
            }

        public bool RemovePerson(Person person)
        {

            return People.Remove(person);    

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
       



    }

}
