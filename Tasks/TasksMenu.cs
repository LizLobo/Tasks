namespace Tasks
{
    public partial class TasksMenu : Form
    {
        public TasksMenu()
        {
            InitializeComponent();
        }

        bool menuExpand = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 230)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }

            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 70)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void taskOne_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void timerMethod_Click(object sender, EventArgs e)
        {

        }
        private void asyncMethod_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 109)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }

            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 399)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}