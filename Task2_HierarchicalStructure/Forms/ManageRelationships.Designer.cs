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
            relationshipTypeComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            relationshipTypeLabel = new ReaLTaiizor.Controls.CrownLabel();
            relatedPersonsComboBox = new ReaLTaiizor.Controls.CrownComboBox();
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
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 21);
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
            nightControlBox1.Location = new Point(490, 0);
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
            label1.Location = new Point(7, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 19);
            label1.TabIndex = 2;
            label1.Text = "Manage Relationships";
            // 
            // mainPersonLabel
            // 
            mainPersonLabel.AutoSize = true;
            mainPersonLabel.ForeColor = Color.FromArgb(220, 220, 220);
            mainPersonLabel.Location = new Point(110, 121);
            mainPersonLabel.Margin = new Padding(2, 0, 2, 0);
            mainPersonLabel.Name = "mainPersonLabel";
            mainPersonLabel.Size = new Size(73, 15);
            mainPersonLabel.TabIndex = 16;
            mainPersonLabel.Text = "Main person";
            // 
            // relationshipTypeComboBox
            // 
            relationshipTypeComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            relationshipTypeComboBox.FormattingEnabled = true;
            relationshipTypeComboBox.Items.AddRange(new object[] { "Female", "Male" });
            relationshipTypeComboBox.Location = new Point(237, 153);
            relationshipTypeComboBox.Margin = new Padding(2, 1, 2, 1);
            relationshipTypeComboBox.Name = "relationshipTypeComboBox";
            relationshipTypeComboBox.Size = new Size(115, 24);
            relationshipTypeComboBox.TabIndex = 19;
            // 
            // relationshipTypeLabel
            // 
            relationshipTypeLabel.AutoSize = true;
            relationshipTypeLabel.ForeColor = Color.FromArgb(220, 220, 220);
            relationshipTypeLabel.Location = new Point(237, 121);
            relationshipTypeLabel.Margin = new Padding(2, 0, 2, 0);
            relationshipTypeLabel.Name = "relationshipTypeLabel";
            relationshipTypeLabel.Size = new Size(99, 15);
            relationshipTypeLabel.TabIndex = 18;
            relationshipTypeLabel.Text = "Relationship Type";
            // 
            // relatedPersonsComboBox
            // 
            relatedPersonsComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            relatedPersonsComboBox.FormattingEnabled = true;
            relatedPersonsComboBox.Items.AddRange(new object[] { "Female", "Male" });
            relatedPersonsComboBox.Location = new Point(419, 153);
            relatedPersonsComboBox.Margin = new Padding(2, 1, 2, 1);
            relatedPersonsComboBox.Name = "relatedPersonsComboBox";
            relatedPersonsComboBox.Size = new Size(181, 24);
            relatedPersonsComboBox.TabIndex = 21;
            // 
            // relatedPersonLabel
            // 
            relatedPersonLabel.AutoSize = true;
            relatedPersonLabel.ForeColor = Color.FromArgb(220, 220, 220);
            relatedPersonLabel.Location = new Point(439, 121);
            relatedPersonLabel.Margin = new Padding(2, 0, 2, 0);
            relatedPersonLabel.Name = "relatedPersonLabel";
            relatedPersonLabel.Size = new Size(85, 15);
            relatedPersonLabel.TabIndex = 20;
            relatedPersonLabel.Text = "Related person";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.ForeColor = Color.FromArgb(220, 220, 220);
            toLabel.Location = new Point(376, 155);
            toLabel.Margin = new Padding(2, 0, 2, 0);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(19, 15);
            toLabel.TabIndex = 22;
            toLabel.Text = "To";
            // 
            // cancelRelationshipButton
            // 
            cancelRelationshipButton.Location = new Point(396, 51);
            cancelRelationshipButton.Margin = new Padding(2, 1, 2, 1);
            cancelRelationshipButton.Name = "cancelRelationshipButton";
            cancelRelationshipButton.Padding = new Padding(3, 2, 3, 2);
            cancelRelationshipButton.Size = new Size(137, 23);
            cancelRelationshipButton.TabIndex = 25;
            cancelRelationshipButton.Text = "Cancel";
            cancelRelationshipButton.Click += cancelRelationshipButton_Click;
            // 
            // removeRelationshipButton
            // 
            removeRelationshipButton.Location = new Point(241, 51);
            removeRelationshipButton.Margin = new Padding(2, 1, 2, 1);
            removeRelationshipButton.Name = "removeRelationshipButton";
            removeRelationshipButton.Padding = new Padding(3, 2, 3, 2);
            removeRelationshipButton.Size = new Size(137, 23);
            removeRelationshipButton.TabIndex = 24;
            removeRelationshipButton.Text = "Remove Relationship";
            // 
            // addRelationshipButton
            // 
            addRelationshipButton.Location = new Point(87, 51);
            addRelationshipButton.Margin = new Padding(2, 1, 2, 1);
            addRelationshipButton.Name = "addRelationshipButton";
            addRelationshipButton.Padding = new Padding(3, 2, 3, 2);
            addRelationshipButton.Size = new Size(137, 23);
            addRelationshipButton.TabIndex = 23;
            addRelationshipButton.Text = "Add Relationship";
            addRelationshipButton.Click += addRelationshipButton_Click;
            // 
            // mainPersonTextbox
            // 
            mainPersonTextbox.BackColor = Color.FromArgb(69, 73, 74);
            mainPersonTextbox.BorderStyle = BorderStyle.FixedSingle;
            mainPersonTextbox.ForeColor = Color.FromArgb(220, 220, 220);
            mainPersonTextbox.Location = new Point(101, 153);
            mainPersonTextbox.Margin = new Padding(2, 1, 2, 1);
            mainPersonTextbox.Name = "mainPersonTextbox";
            mainPersonTextbox.Size = new Size(103, 23);
            mainPersonTextbox.TabIndex = 26;
            // 
            // ManageRelationships
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(629, 225);
            Controls.Add(mainPersonTextbox);
            Controls.Add(cancelRelationshipButton);
            Controls.Add(removeRelationshipButton);
            Controls.Add(addRelationshipButton);
            Controls.Add(toLabel);
            Controls.Add(relatedPersonsComboBox);
            Controls.Add(relatedPersonLabel);
            Controls.Add(relationshipTypeComboBox);
            Controls.Add(relationshipTypeLabel);
            Controls.Add(mainPersonLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
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
        private ReaLTaiizor.Controls.CrownComboBox relationshipTypeComboBox;
        private ReaLTaiizor.Controls.CrownLabel relationshipTypeLabel;
        private ReaLTaiizor.Controls.CrownComboBox relatedPersonsComboBox;
        private ReaLTaiizor.Controls.CrownLabel relatedPersonLabel;
        private ReaLTaiizor.Controls.CrownLabel toLabel;
        private ReaLTaiizor.Controls.CrownButton cancelRelationshipButton;
        private ReaLTaiizor.Controls.CrownButton removeRelationshipButton;
        private ReaLTaiizor.Controls.CrownButton addRelationshipButton;
        private ReaLTaiizor.Controls.CrownTextBox mainPersonTextbox;
    }
}