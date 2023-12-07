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
        private PersonModel personModel;
        private PersonList personListForm;

        private List<Person> allPersons;

        public ManageRelationships(PersonList personListForm, List<Person> persons)
        {
            InitializeComponent();
            personModel = personListForm._personModel;
            _personController = new PersonController(personModel);
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


        public void PopulateRelatedPersonCombo(string mainPersonId) 
        {
            var relatedPersons = allPersons.Where(p => p.Id != mainPersonId).ToList();
            relatedPersonsComboBox.DataSource = relatedPersons;
            relatedPersonsComboBox.DisplayMember = $"{relatedPersons.Name}";
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
