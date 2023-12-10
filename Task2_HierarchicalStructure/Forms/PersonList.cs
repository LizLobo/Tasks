using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Task2_HierarchicalStructure.Controller;
using Task2_HierarchicalStructure.Forms;
using Task2_HierarchicalStructure.Model;

namespace Task2_HierarchicalStructure
{
    public partial class PersonList : Form
    {
        public PersonController personController = new PersonController();
        private readonly string jsonFilePath;

        public PersonList()
        {
            InitializeComponent();
            LoadDataGridView(); 
            DisplayPeopleInDataGridView();

        }

        private void LoadDataGridView()
        {
            personDataGridView.ColumnCount = 3;
            personDataGridView.Columns[0].Name = "ID";
            personDataGridView.Columns[1].Name = "Person";
            personDataGridView.Columns[2].Name = "Relations";


        }

        public void DisplayPeopleInDataGridView()
        {
            personDataGridView.Rows.Clear();

            foreach (Person person in personController.GetPeopleList())
            {
                
                string relationshipsInfo = GetRelationshipsInfo(person);

                personDataGridView.Rows.Add(person.Id, person.Name + " " + person.Surname, relationshipsInfo);
            }
        }

        private string GetRelationshipsInfo(Person person)
        {
            StringBuilder relationships = new StringBuilder();

            foreach (Relationships relationship in person.Relationships)
            {
                if (relationship.RelatedPerson != null && relationship.RelatedPerson.Name != null)
                {
                    relationships.Append($"{relationship.Type} with {relationship.RelatedPerson.Name}, ");
                }
                else
                {
                    relationships.Append($"{relationship.Type} with unknown person, ");
                }
            }

            // Remove the trailing comma and space if relationships exist
            if (relationships.Length > 0)
            {
                relationships.Length -= 2;
            }

            return relationships.ToString();
        }
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            ShowFormPersonInfo();

        }

        private void ShowFormPersonInfo()
        {
            PersonInfo personInfoForm = new PersonInfo(this);
            personInfoForm.FormClosed += (s, ev) => DisplayPeopleInDataGridView(); 
            personInfoForm.ShowDialog();
        }

        private void personDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (personDataGridView.SelectedRows.Count > 0)
            {
                removePersonButton.Enabled = true;
            }
            else
            {
                removePersonButton.Enabled = false;
            }
        }

        private void removePersonButton_Click(object sender, EventArgs e)
        {
            if (personDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = personDataGridView.SelectedRows[0];

                Person personToRemove = GetPersonFromSelectedRow(selectedRow);

                RemovePerson(personToRemove);

                DisplayPeopleInDataGridView();
            }
        }

        private Person GetPersonFromSelectedRow(DataGridViewRow selectedRow)
        {
            string personId = selectedRow.Cells["ID"].Value.ToString(); ;

            return personController.GetPeopleList().FirstOrDefault(p => p.Id == personId);
        }

        private void RemovePerson(Person person)
        {
            bool removed = personController.RemovePerson(person);

            if (removed)
            {
                MessageBox.Show("Person removed successfully!");
            }
            else
            {
                MessageBox.Show("Failed to remove person.");
            }
        }

        private void manageRelationshipsButton_Click(object sender, EventArgs e)
        {
            if (personDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = personDataGridView.SelectedRows[0];

                Person mainPerson = GetPersonFromSelectedRow(selectedRow);

                if (mainPerson != null)
                {
                    ShowFormManageRelationships(mainPerson);
                }

                else
                {
                    MessageBox.Show("Please select a person from the list.");
                }
            }
        }

        private void ShowFormManageRelationships(Person mainPerson)
        {
            ManageRelationships manageRelationshipsForm = new ManageRelationships(this, personController.GetPeopleList());
            manageRelationshipsForm.SetMainPersonDetails(mainPerson);
            manageRelationshipsForm.PopulateRelatedPersonCombo(mainPerson.Id);
            manageRelationshipsForm.PopulateRelationshipTypesCombo();
            manageRelationshipsForm.FormClosed += (s, ev) => DisplayPeopleInDataGridView();
            manageRelationshipsForm.Show();
        }
    }
}