namespace Task2_HierarchicalStructure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            MemberInfo addMemberInfo = new MemberInfo();

            addMemberInfo.ShowDialog();
        }
    }
}