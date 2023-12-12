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

        public void DisplayRelationshipsInDataGridView(Person mainPerson)
        {
            this.mainPerson = mainPerson;
            mpRelationshipDataGridView.Rows.Clear();

            foreach (Relationship relationship in mainPerson.Relationships)
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

        private void removeRelationshipButton_Click(object sender, EventArgs e)
        {
            if (mpRelationshipDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = mpRelationshipDataGridView.SelectedRows[0];

                Relationship relationToRemove = GetRelationFromSelectedRow(selectedRow);

                _personController.RemoveRelationship(mainPerson, relationToRemove);

                DisplayRelationshipsInDataGridView(mainPerson);

            }   
        }

        private Relationship GetRelationFromSelectedRow(DataGridViewRow selectedRow)
        {
            if (selectedRow != null && selectedRow.Cells.Count >= 2)
            {
                // Assuming the cells' values in the DataGridView are strings or convertible to the desired types
                Person relatedPerson = selectedRow.Cells["RelatedPerson"].Value as Person;
                RelationshipType selectedRelationship;

                if (Enum.TryParse(selectedRow.Cells["RelationshipType"].Value?.ToString(), out selectedRelationship))
                {
                    return new Relationship(relatedPerson, selectedRelationship); // Assuming a constructor for Relationship
                }
            }

            return null; // Return null if the information cannot be retrieved
        }
    }
}
