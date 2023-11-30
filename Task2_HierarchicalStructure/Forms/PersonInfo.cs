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

namespace Task2_HierarchicalStructure
{
    public partial class PersonInfo : Form
    {
        private readonly PersonController _personController;
        private PersonModel personModel;
        private PersonList personListForm;

        public PersonInfo(PersonList personListForm)
        {
            InitializeComponent();
            personModel = new PersonModel();
            _personController = new PersonController(personModel);
            this.personListForm = personListForm;

            string uniqueId = GenerateUniqueId(); // Generate a unique ID (you might have your own way to generate IDs)
            idNumberTextbox.Text = uniqueId; // Set the generated ID to the TextBox

            // Disable TextBox editing
            idNumberTextbox.ReadOnly = true;
        }

        private void addPersonCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addPersonSaveButton_Click(object sender, EventArgs e)
        {
            string id = idNumberTextbox.Text;
            string name = nameTextbox.Text;
            string surname = surnameTextbox.Text;
            int age = (int)ageNumeric.Value;
            string sex = sexComboBox.SelectedItem?.ToString();
            string gender = genderComboBox.SelectedItem?.ToString();
            bool isDeceased = relationshipCheckBox.Checked;

            Person person = new Person(id, name, surname, age, sex, gender, isDeceased);
            _personController.AddPerson(person);

            string newUniqueId = GenerateUniqueId();
            idNumberTextbox.Text = newUniqueId;

            // Call RefreshDataGridView() on the PersonList instance to update the DataGridView
            personListForm.DisplayPeopleInDataGridView();

            // Close the current PersonInfo form
            this.Close();
        }

        private string GenerateUniqueId()
        {
            return Guid.NewGuid().ToString();
        }


    }
}
