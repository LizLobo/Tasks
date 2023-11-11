namespace Tasks
{
    partial class TasksMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksMenu));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            menuContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            taskOne = new Button();
            panel2 = new Panel();
            timerMethod = new Button();
            panel7 = new Panel();
            asyncMethod = new Button();
            panel3 = new Panel();
            taskTwo = new Button();
            panel4 = new Panel();
            taskThree = new Button();
            panel5 = new Panel();
            taskFour = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            menuContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1458, 65);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1319, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(123, 12);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 2;
            label1.Text = "TASKS";
            label1.Click += label1_Click;
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(21, 4);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(68, 58);
            btnHam.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(23, 24, 29);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 65);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 30, 0, 0);
            sidebar.Size = new Size(399, 805);
            sidebar.TabIndex = 1;
            sidebar.Paint += sidebar_Paint;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(32, 33, 36);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel2);
            menuContainer.Controls.Add(panel7);
            menuContainer.Location = new Point(3, 33);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(396, 71);
            menuContainer.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Controls.Add(taskOne);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(396, 71);
            panel6.TabIndex = 5;
            // 
            // taskOne
            // 
            taskOne.BackColor = Color.FromArgb(23, 24, 29);
            taskOne.ForeColor = Color.White;
            taskOne.Image = (Image)resources.GetObject("taskOne.Image");
            taskOne.ImageAlign = ContentAlignment.MiddleLeft;
            taskOne.Location = new Point(-9, -11);
            taskOne.Margin = new Padding(0);
            taskOne.Name = "taskOne";
            taskOne.Padding = new Padding(25, 0, 0, 0);
            taskOne.Size = new Size(417, 95);
            taskOne.TabIndex = 2;
            taskOne.Text = "                 Task One";
            taskOne.TextAlign = ContentAlignment.MiddleLeft;
            taskOne.UseVisualStyleBackColor = false;
            taskOne.Click += taskOne_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(timerMethod);
            panel2.Location = new Point(0, 71);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 71);
            panel2.TabIndex = 3;
            // 
            // timerMethod
            // 
            timerMethod.BackColor = Color.FromArgb(32, 33, 36);
            timerMethod.ForeColor = Color.White;
            timerMethod.Image = (Image)resources.GetObject("timerMethod.Image");
            timerMethod.ImageAlign = ContentAlignment.MiddleLeft;
            timerMethod.Location = new Point(-9, -15);
            timerMethod.Margin = new Padding(0);
            timerMethod.Name = "timerMethod";
            timerMethod.Padding = new Padding(25, 0, 0, 0);
            timerMethod.Size = new Size(417, 95);
            timerMethod.TabIndex = 2;
            timerMethod.Text = "                 Timer Method";
            timerMethod.TextAlign = ContentAlignment.MiddleLeft;
            timerMethod.UseVisualStyleBackColor = false;
            timerMethod.Click += timerMethod_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(asyncMethod);
            panel7.Location = new Point(0, 142);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(396, 71);
            panel7.TabIndex = 5;
            // 
            // asyncMethod
            // 
            asyncMethod.BackColor = Color.FromArgb(32, 33, 36);
            asyncMethod.ForeColor = Color.White;
            asyncMethod.Image = (Image)resources.GetObject("asyncMethod.Image");
            asyncMethod.ImageAlign = ContentAlignment.MiddleLeft;
            asyncMethod.Location = new Point(-8, -12);
            asyncMethod.Margin = new Padding(0);
            asyncMethod.Name = "asyncMethod";
            asyncMethod.Padding = new Padding(25, 0, 0, 0);
            asyncMethod.Size = new Size(417, 95);
            asyncMethod.TabIndex = 2;
            asyncMethod.Text = "                 Async Method";
            asyncMethod.TextAlign = ContentAlignment.MiddleLeft;
            asyncMethod.UseVisualStyleBackColor = false;
            asyncMethod.Click += asyncMethod_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(taskTwo);
            panel3.Location = new Point(3, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(396, 71);
            panel3.TabIndex = 4;
            // 
            // taskTwo
            // 
            taskTwo.BackColor = Color.FromArgb(23, 24, 29);
            taskTwo.ForeColor = Color.White;
            taskTwo.Image = (Image)resources.GetObject("taskTwo.Image");
            taskTwo.ImageAlign = ContentAlignment.MiddleLeft;
            taskTwo.Location = new Point(-10, -10);
            taskTwo.Name = "taskTwo";
            taskTwo.Padding = new Padding(25, 0, 0, 0);
            taskTwo.Size = new Size(417, 95);
            taskTwo.TabIndex = 2;
            taskTwo.Text = "                 Task Two";
            taskTwo.TextAlign = ContentAlignment.MiddleLeft;
            taskTwo.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(taskThree);
            panel4.Location = new Point(3, 187);
            panel4.Name = "panel4";
            panel4.Size = new Size(396, 71);
            panel4.TabIndex = 5;
            // 
            // taskThree
            // 
            taskThree.BackColor = Color.FromArgb(23, 24, 29);
            taskThree.ForeColor = Color.White;
            taskThree.Image = (Image)resources.GetObject("taskThree.Image");
            taskThree.ImageAlign = ContentAlignment.MiddleLeft;
            taskThree.Location = new Point(-9, -12);
            taskThree.Name = "taskThree";
            taskThree.Padding = new Padding(25, 0, 0, 0);
            taskThree.Size = new Size(417, 95);
            taskThree.TabIndex = 2;
            taskThree.Text = "                 Task Three";
            taskThree.TextAlign = ContentAlignment.MiddleLeft;
            taskThree.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(taskFour);
            panel5.Location = new Point(3, 264);
            panel5.Name = "panel5";
            panel5.Size = new Size(396, 71);
            panel5.TabIndex = 6;
            // 
            // taskFour
            // 
            taskFour.BackColor = Color.FromArgb(23, 24, 29);
            taskFour.ForeColor = Color.White;
            taskFour.Image = (Image)resources.GetObject("taskFour.Image");
            taskFour.ImageAlign = ContentAlignment.MiddleLeft;
            taskFour.Location = new Point(-9, -12);
            taskFour.Name = "taskFour";
            taskFour.Padding = new Padding(25, 0, 0, 0);
            taskFour.Size = new Size(417, 95);
            taskFour.TabIndex = 2;
            taskFour.Text = "                 Task Four";
            taskFour.TextAlign = ContentAlignment.MiddleLeft;
            taskFour.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 870);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Button timerMethod;
        private Panel panel2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.CrownContextMenuStrip crownContextMenuStrip1;
        private Panel panel3;
        private Button taskTwo;
        private Panel panel4;
        private Button taskThree;
        private Panel panel5;
        private Button taskFour;
        private FlowLayoutPanel menuContainer;
        private Panel panel6;
        private Button taskOne;
        private Panel panel7;
        private Button asyncMethod;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}