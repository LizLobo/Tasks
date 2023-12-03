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

        public ManageRelationships(PersonList personListForm)
        {
            InitializeComponent();
            personModel = personListForm._personModel;
            _personController = new PersonController(personModel);
            this.personListForm = personListForm;
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
