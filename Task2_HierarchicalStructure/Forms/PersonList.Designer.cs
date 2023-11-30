namespace Task2_HierarchicalStructure
{
    partial class PersonList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            addPersonButton = new ReaLTaiizor.Controls.CrownButton();
            removePersonButton = new ReaLTaiizor.Controls.CrownButton();
            editPersonButton = new ReaLTaiizor.Controls.CrownButton();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            personDataGridView = new DataGridView();
            manageRelationshipsButton = new ReaLTaiizor.Controls.CrownButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addPersonButton
            // 
            addPersonButton.Location = new Point(98, 97);
            addPersonButton.Name = "addPersonButton";
            addPersonButton.Padding = new Padding(5);
            addPersonButton.Size = new Size(234, 46);
            addPersonButton.TabIndex = 0;
            addPersonButton.Text = "Add Person";
            addPersonButton.Click += addPersonButton_Click;
            // 
            // removePersonButton
            // 
            removePersonButton.Location = new Point(362, 97);
            removePersonButton.Name = "removePersonButton";
            removePersonButton.Padding = new Padding(5);
            removePersonButton.Size = new Size(234, 46);
            removePersonButton.TabIndex = 1;
            removePersonButton.Text = "Remove Person";
            // 
            // editPersonButton
            // 
            editPersonButton.Location = new Point(628, 97);
            editPersonButton.Name = "editPersonButton";
            editPersonButton.Padding = new Padding(5);
            editPersonButton.Size = new Size(234, 46);
            editPersonButton.TabIndex = 3;
            editPersonButton.Text = "Edit Person";
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
            panel1.Size = new Size(1247, 41);
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
            nightControlBox1.Location = new Point(1108, 0);
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
            label1.Size = new Size(127, 32);
            label1.TabIndex = 2;
            label1.Text = "Person List";
            // 
            // personDataGridView
            // 
            personDataGridView.BackgroundColor = Color.FromArgb(23, 24, 29);
            personDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            personDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            personDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            personDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            personDataGridView.GridColor = SystemColors.ControlDarkDark;
            personDataGridView.Location = new Point(98, 253);
            personDataGridView.Name = "personDataGridView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(23, 24, 29);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            personDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            personDataGridView.RowHeadersWidth = 72;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(23, 24, 29);
            personDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            personDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            personDataGridView.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.Control;
            personDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.MenuHighlight;
            personDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.Control;
            personDataGridView.RowTemplate.Height = 37;
            personDataGridView.Size = new Size(1030, 322);
            personDataGridView.TabIndex = 6;
            // 
            // manageRelationshipsButton
            // 
            manageRelationshipsButton.Location = new Point(894, 97);
            manageRelationshipsButton.Name = "manageRelationshipsButton";
            manageRelationshipsButton.Padding = new Padding(5);
            manageRelationshipsButton.Size = new Size(234, 46);
            manageRelationshipsButton.TabIndex = 7;
            manageRelationshipsButton.Text = "Manage Relationships";
            // 
            // PersonList
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(1247, 627);
            Controls.Add(manageRelationshipsButton);
            Controls.Add(personDataGridView);
            Controls.Add(panel1);
            Controls.Add(crownLabel1);
            Controls.Add(editPersonButton);
            Controls.Add(removePersonButton);
            Controls.Add(addPersonButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task2_HierarchicalStructure";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)personDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CrownButton addPersonButton;
        private ReaLTaiizor.Controls.CrownButton removePersonButton;
        private ReaLTaiizor.Controls.CrownButton editPersonButton;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private DataGridView personDataGridView;
        private ReaLTaiizor.Controls.CrownButton editRelationshipsButton;
        private ReaLTaiizor.Controls.CrownButton manageRelationshipsButton;
    }
}