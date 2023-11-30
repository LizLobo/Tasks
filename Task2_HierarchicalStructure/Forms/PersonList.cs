using System.Text;
using System.Windows.Forms;
using Task2_HierarchicalStructure.Controller;
using Task2_HierarchicalStructure.Model;

namespace Task2_HierarchicalStructure
{
    public partial class PersonList : Form
    {
        private PersonController _personController;
        public PersonList(PersonController personController)
        {
            InitializeComponent();
            _personController = personController;
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

            // Add rows to the DataGridView
            personDataGridView.Rows.Add(1, "John", null);
            personDataGridView.Rows.Add(2, "Alice", null);
            // Add more rows as needed
        }

        private void DisplayPeopleInDataGridView()
        {
            List<Person> peopleList = _personController.GetPeopleList();

            // Clear existing rows
            personDataGridView.Rows.Clear();

            foreach (Person person in peopleList)
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
            personInfoForm.FormClosed += (s, ev) => RefreshDataGridView(); // Attach an event handler to FormClosed
            personInfoForm.ShowDialog();
        }

        public void RefreshDataGridView()
        {
            DisplayPeopleInDataGridView(); // Update the DataGridView's DataSource
        }
    }
}