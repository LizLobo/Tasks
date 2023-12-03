namespace Task2_HierarchicalStructure.Forms
{
    partial class ManageRelationships
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            mainPersonLabel = new ReaLTaiizor.Controls.CrownLabel();
            crownComboBox1 = new ReaLTaiizor.Controls.CrownComboBox();
            relationshipTypeLabel = new ReaLTaiizor.Controls.CrownLabel();
            crownComboBox2 = new ReaLTaiizor.Controls.CrownComboBox();
            relatedPersonLabel = new ReaLTaiizor.Controls.CrownLabel();
            toLabel = new ReaLTaiizor.Controls.CrownLabel();
            cancelRelationshipButton = new ReaLTaiizor.Controls.CrownButton();
            removeRelationshipButton = new ReaLTaiizor.Controls.CrownButton();
            addRelationshipButton = new ReaLTaiizor.Controls.CrownButton();
            mainPersonTextbox = new ReaLTaiizor.Controls.CrownTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1168, 44);
            panel1.TabIndex = 6;
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
            nightControlBox1.Location = new Point(1029, 0);
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
            label1.Location = new Point(13, 4);
            label1.Name = "label1";
            label1.Size = new Size(288, 38);
            label1.TabIndex = 2;
            label1.Text = "Manage Relationships";
            // 
            // mainPersonLabel
            // 
            mainPersonLabel.AutoSize = true;
            mainPersonLabel.ForeColor = Color.FromArgb(220, 220, 220);
            mainPersonLabel.Location = new Point(205, 259);
            mainPersonLabel.Name = "mainPersonLabel";
            mainPersonLabel.Size = new Size(148, 32);
            mainPersonLabel.TabIndex = 16;
            mainPersonLabel.Text = "Main person";
            // 
            // crownComboBox1
            // 
            crownComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            crownComboBox1.FormattingEnabled = true;
            crownComboBox1.Items.AddRange(new object[] { "Female", "Male" });
            crownComboBox1.Location = new Point(440, 326);
            crownComboBox1.Name = "crownComboBox1";
            crownComboBox1.Size = new Size(189, 40);
            crownComboBox1.TabIndex = 19;
            // 
            // relationshipTypeLabel
            // 
            relationshipTypeLabel.AutoSize = true;
            relationshipTypeLabel.ForeColor = Color.FromArgb(220, 220, 220);
            relationshipTypeLabel.Location = new Point(440, 259);
            relationshipTypeLabel.Name = "relationshipTypeLabel";
            relationshipTypeLabel.Size = new Size(202, 32);
            relationshipTypeLabel.TabIndex = 18;
            relationshipTypeLabel.Text = "Relationship Type";
            // 
            // crownComboBox2
            // 
            crownComboBox2.DrawMode = DrawMode.OwnerDrawVariable;
            crownComboBox2.FormattingEnabled = true;
            crownComboBox2.Items.AddRange(new object[] { "Female", "Male" });
            crownComboBox2.Location = new Point(798, 326);
            crownComboBox2.Name = "crownComboBox2";
            crownComboBox2.Size = new Size(175, 40);
            crownComboBox2.TabIndex = 21;
            // 
            // relatedPersonLabel
            // 
            relatedPersonLabel.AutoSize = true;
            relatedPersonLabel.ForeColor = Color.FromArgb(220, 220, 220);
            relatedPersonLabel.Location = new Point(816, 259);
            relatedPersonLabel.Name = "relatedPersonLabel";
            relatedPersonLabel.Size = new Size(173, 32);
            relatedPersonLabel.TabIndex = 20;
            relatedPersonLabel.Text = "Related person";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.ForeColor = Color.FromArgb(220, 220, 220);
            toLabel.Location = new Point(698, 330);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(39, 32);
            toLabel.TabIndex = 22;
            toLabel.Text = "To";
            // 
            // cancelRelationshipButton
            // 
            cancelRelationshipButton.Location = new Point(736, 109);
            cancelRelationshipButton.Name = "cancelRelationshipButton";
            cancelRelationshipButton.Padding = new Padding(5);
            cancelRelationshipButton.Size = new Size(254, 49);
            cancelRelationshipButton.TabIndex = 25;
            cancelRelationshipButton.Text = "Cancel";
            cancelRelationshipButton.Click += cancelRelationshipButton_Click;
            // 
            // removeRelationshipButton
            // 
            removeRelationshipButton.Location = new Point(447, 109);
            removeRelationshipButton.Name = "removeRelationshipButton";
            removeRelationshipButton.Padding = new Padding(5);
            removeRelationshipButton.Size = new Size(254, 49);
            removeRelationshipButton.TabIndex = 24;
            removeRelationshipButton.Text = "Remove Relationship";
            // 
            // addRelationshipButton
            // 
            addRelationshipButton.Location = new Point(161, 109);
            addRelationshipButton.Name = "addRelationshipButton";
            addRelationshipButton.Padding = new Padding(5);
            addRelationshipButton.Size = new Size(254, 49);
            addRelationshipButton.TabIndex = 23;
            addRelationshipButton.Text = "Add Relationship";
            addRelationshipButton.Click += addRelationshipButton_Click;
            // 
            // mainPersonTextbox
            // 
            mainPersonTextbox.BackColor = Color.FromArgb(69, 73, 74);
            mainPersonTextbox.BorderStyle = BorderStyle.FixedSingle;
            mainPersonTextbox.ForeColor = Color.FromArgb(220, 220, 220);
            mainPersonTextbox.Location = new Point(188, 326);
            mainPersonTextbox.Name = "mainPersonTextbox";
            mainPersonTextbox.Size = new Size(189, 39);
            mainPersonTextbox.TabIndex = 26;
            // 
            // ManageRelationships
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(1168, 480);
            Controls.Add(mainPersonTextbox);
            Controls.Add(cancelRelationshipButton);
            Controls.Add(removeRelationshipButton);
            Controls.Add(addRelationshipButton);
            Controls.Add(toLabel);
            Controls.Add(crownComboBox2);
            Controls.Add(relatedPersonLabel);
            Controls.Add(crownComboBox1);
            Controls.Add(relationshipTypeLabel);
            Controls.Add(mainPersonLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageRelationships";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Relationships";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private ReaLTaiizor.Controls.CrownLabel mainPersonLabel;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox1;
        private ReaLTaiizor.Controls.CrownLabel relationshipTypeLabel;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox2;
        private ReaLTaiizor.Controls.CrownLabel relatedPersonLabel;
        private ReaLTaiizor.Controls.CrownLabel toLabel;
        private ReaLTaiizor.Controls.CrownButton cancelRelationshipButton;
        private ReaLTaiizor.Controls.CrownButton removeRelationshipButton;
        private ReaLTaiizor.Controls.CrownButton addRelationshipButton;
        private ReaLTaiizor.Controls.CrownTextBox mainPersonTextbox;
    }
}