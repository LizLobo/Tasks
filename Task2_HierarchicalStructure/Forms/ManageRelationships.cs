using ReaLTaiizor.Controls;
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
        public Person mainPerson;
       

        private List<Person> allPersons;

        public ManageRelationships(PersonList personListForm, List<Person> persons)
        {
            InitializeComponent();
           
            _personController = new PersonController();
            this.personListForm = personListForm;
            allPersons = persons;
            LoadDataGridView();
            


        }

        private void LoadDataGridView()
        {
            mpRelationshipDataGridView.ColumnCount = 2;
            mpRelationshipDataGridView.Columns[0].Name = "RelationshipType";
            mpRelationshipDataGridView.Columns[1].Name = "RelatedPerson";

        }

        public void DisplayRelationshipsInDataGridView (Person mainPerson)
        {
            this.mainPerson = mainPerson;
            mpRelationshipDataGridView.Rows.Clear();

            foreach (Relationships relationship in mainPerson.Relationships)
            {
                if (relationship.RelatedPerson != null && relationship.RelatedPerson.Name != null)
                {
                    mpRelationshipDataGridView.Rows.Add(
                        relationship.Type, relationship.RelatedPerson.Name);
                }

            }
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
                      
            cbxNames.DataSource = relatedPersons;
            cbxNames.DisplayMember = "Name";
            cbxNames.ValueMember = "Id";

        }

        public void AddRelationshiptoMainPerson(Person mainPerson)
        {
           
            

        }

        //TODO Get mainPerson to pass in from PersonList.
        private void addRelationshipButton_Click(object sender, EventArgs e)
        {
            if (mainPerson != null)
            {
                if (relationshipTypeComboBox.SelectedItem is RelationshipType selectedRelationship &&
            cbxNames.SelectedItem is Person relatedPerson)
              {
                  _personController.AddRelationship(mainPerson, relatedPerson, selectedRelationship);
              }
            }
            
        }

        private void cancelRelationshipButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
