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
    public partial class MemberInfo : Form
    {
        public MemberInfo()
        {
            InitializeComponent();
        }

        private void addMemberCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addMemberSaveButton_Click(object sender, EventArgs e)
        {
            Person person = new Person(nameTextbox.Text);
            PersonController.AddPerson(person);
        }
    }
}
