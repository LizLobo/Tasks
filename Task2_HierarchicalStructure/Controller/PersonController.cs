﻿using System;
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
        
           List<Person> parentObjects = new List<Person>();
           List<Person> siblingObjects = new List<Person>();
            List<Person> childrenObjects = new List<Person>();

        private PersonModel _personModel;
        private PersonView _personView;
        public PersonController(PersonModel personModel, PersonView personView) 
        {
            _personModel = personModel;
            _personView = personView;
        }
        public void AddPerson(Person person)
        {
           _personModel.AddPerson(person);
        }

        public List<Person> GetPeopleList()
        {
            return _personModel.PersonList;
        }


        public static void RemovePerson(Person person)
        {
           // persons.Remove(person);
        }


        
        

      
    }
}
