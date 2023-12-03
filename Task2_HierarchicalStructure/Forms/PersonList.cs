using System.Text;
using System.Windows.Forms;
using Task2_HierarchicalStructure.Controller;
using Task2_HierarchicalStructure.Model;

namespace Task2_HierarchicalStructure
{
    public partial class PersonList : Form
    {
        public PersonController _personController;
        public PersonModel _personModel;
        public PersonList(PersonController personController, PersonModel personModel)
        {
            InitializeComponent();
            _personController = personController;
            _personModel = personModel;
            LoadDataGridView(); // Call a method to load or configure the DataGridView
            DisplayPeopleInDataGridView();

        }

        private void LoadDataGridView()
        {
            // Access the DataGridView and modify its properties or data
            personDataGridView.ColumnCount = 3;
            personDataGridView.Columns[0].Name = "ID";
            personDataGridView.Columns[1].Name = "Person";
            personDataGridView.Columns[2].Name = "Relations";


        }

        public void DisplayPeopleInDataGridView()
        {


            // Clear existing rows
            personDataGridView.Rows.Clear();

            foreach (Person person in _personController.GetPeopleList())
            {
                // Extract relationships information for display
                string relationshipsInfo = GetRelationshipsInfo(person);

                // Add a new row to the DataGridView
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
            personInfoForm.FormClosed += (s, ev) => DisplayPeopleInDataGridView(); // Attach an event handler to FormClosed
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

            return _personController.GetPeopleList().FirstOrDefault(p => p.Id == personId);
        }

        private void RemovePerson(Person person)
        {
            bool removed = _personController.RemovePerson(person);

            if (removed)
            {
                _personModel.RemovePersonFromJsonFile(person);
                MessageBox.Show("Person removed successfully!");
            }
            else
            {
                MessageBox.Show("Failed to remove person.");
            }
        }

        private void manageRelationshipsButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowFormRelationships()
        {
            ManageRelationships manageRelationshipsForm = new ManageRelationships(this);
            manageRelationshipsForm.FormClosed += (s, ev) => DisplayPeopleInDataGridView(); // Attach an event handler to FormClosed
            manageRelationshipsForm.ShowDialog();
        }
    }
}