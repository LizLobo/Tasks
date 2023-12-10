using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2_HierarchicalStructure.Controller;
using Task2_HierarchicalStructure.Model;

namespace Task2_HierarchicalStructure.Forms
{
    public partial class ManageRelationships : Form
    {

        private readonly PersonController _personController;
        PersonModel personModel = PersonModel.GetInstance();
        private PersonList personListForm;

        private List<Person> allPersons;

        public ManageRelationships(PersonList personListForm, List<Person> persons)
        {
            InitializeComponent();
           
            _personController = new PersonController();
            this.personListForm = personListForm;
            allPersons = persons;


        }

        public void SetMainPersonDetails(Person mainPerson)
        {
            mainPersonTextbox.Text = $"{mainPerson.Name} {mainPerson.Surname}";

            mainPersonTextbox.ReadOnly = true;
        }

        public void PopulateRelationshipTypesCombo() 
        {
            relationshipTypeComboBox.DataSource = Enum.GetValues(typeof(RelationshipType));
        }

        //@LIZ Iterate through the relatedPersons list to bring back each Person object's name and the value of their ID.
        public void PopulateRelatedPersonCombo(string mainPersonId) 
        {
            var relatedPersons = allPersons.Where(p => p.Id != mainPersonId).ToList();
            relatedPersonsComboBox.DataSource = relatedPersons;
            relatedPersonsComboBox.DisplayMember = "Name";
            relatedPersonsComboBox.ValueMember = "Id";

        }


        private void addRelationshipButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelRelationshipButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
