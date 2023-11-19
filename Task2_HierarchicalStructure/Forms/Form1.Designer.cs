namespace Task2_HierarchicalStructure
{
    partial class Form1
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
            addMemberButton = new ReaLTaiizor.Controls.CrownButton();
            crownButton1 = new ReaLTaiizor.Controls.CrownButton();
            personsListView = new ReaLTaiizor.Controls.CrownListView();
            crownButton2 = new ReaLTaiizor.Controls.CrownButton();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addMemberButton
            // 
            addMemberButton.Location = new Point(98, 97);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Padding = new Padding(5);
            addMemberButton.Size = new Size(234, 46);
            addMemberButton.TabIndex = 0;
            addMemberButton.Text = "Add Member";
            addMemberButton.Click += addMemberButton_Click;
            // 
            // crownButton1
            // 
            crownButton1.Location = new Point(466, 97);
            crownButton1.Name = "crownButton1";
            crownButton1.Padding = new Padding(5);
            crownButton1.Size = new Size(234, 46);
            crownButton1.TabIndex = 1;
            crownButton1.Text = "Remove Member";
            // 
            // personsListView
            // 
            personsListView.Location = new Point(100, 227);
            personsListView.Name = "personsListView";
            personsListView.Size = new Size(981, 358);
            personsListView.TabIndex = 2;
            personsListView.Text = "personsListView";
            // 
            // crownButton2
            // 
            crownButton2.Location = new Point(845, 97);
            crownButton2.Name = "crownButton2";
            crownButton2.Padding = new Padding(5);
            crownButton2.Size = new Size(234, 46);
            crownButton2.TabIndex = 3;
            crownButton2.Text = "Edit Member";
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel1.Location = new Point(100, 179);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(117, 30);
            crownLabel1.TabIndex = 4;
            crownLabel1.Text = "Person List:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 41);
            panel1.TabIndex = 5;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1037, 0);
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
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 2;
            label1.Text = "A Family";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(1176, 627);
            Controls.Add(panel1);
            Controls.Add(crownLabel1);
            Controls.Add(crownButton2);
            Controls.Add(personsListView);
            Controls.Add(crownButton1);
            Controls.Add(addMemberButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task2_HierarchicalStructure";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CrownButton addMemberButton;
        private ReaLTaiizor.Controls.CrownButton crownButton1;
        private ReaLTaiizor.Controls.CrownListView personsListView;
        private ReaLTaiizor.Controls.CrownButton crownButton2;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
    }
}