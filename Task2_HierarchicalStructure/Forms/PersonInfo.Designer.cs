namespace Task2_HierarchicalStructure
{
    partial class PersonInfo
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
            nameLabel = new ReaLTaiizor.Controls.CrownLabel();
            surnameLabel = new ReaLTaiizor.Controls.CrownLabel();
            ageLabel = new ReaLTaiizor.Controls.CrownLabel();
            ageNumeric = new ReaLTaiizor.Controls.CrownNumeric();
            surnameTextbox = new ReaLTaiizor.Controls.CrownTextBox();
            nameTextbox = new ReaLTaiizor.Controls.CrownTextBox();
            sexLabel = new ReaLTaiizor.Controls.CrownLabel();
            genderLabel = new ReaLTaiizor.Controls.CrownLabel();
            idNumberTextbox = new ReaLTaiizor.Controls.CrownTextBox();
            idNumberLabel = new ReaLTaiizor.Controls.CrownLabel();
            sexComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            genderComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            addPersonSaveButton = new ReaLTaiizor.Controls.CrownButton();
            addMemberCancelButton = new ReaLTaiizor.Controls.CrownButton();
            deceasedLabel = new ReaLTaiizor.Controls.CrownLabel();
            relationshipCheckBox = new ReaLTaiizor.Controls.CrownCheckBox();
            ((System.ComponentModel.ISupportInitialize)ageNumeric).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.FromArgb(220, 220, 220);
            nameLabel.Location = new Point(248, 202);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(83, 32);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.ForeColor = Color.FromArgb(220, 220, 220);
            surnameLabel.Location = new Point(248, 273);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(114, 32);
            surnameLabel.TabIndex = 1;
            surnameLabel.Text = "Surname:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.ForeColor = Color.FromArgb(220, 220, 220);
            ageLabel.Location = new Point(248, 345);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(61, 32);
            ageLabel.TabIndex = 2;
            ageLabel.Text = "Age:";
            // 
            // ageNumeric
            // 
            ageNumeric.Location = new Point(398, 341);
            ageNumeric.Name = "ageNumeric";
            ageNumeric.Size = new Size(176, 39);
            ageNumeric.TabIndex = 4;
            ageNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // surnameTextbox
            // 
            surnameTextbox.BackColor = Color.FromArgb(69, 73, 74);
            surnameTextbox.BorderStyle = BorderStyle.FixedSingle;
            surnameTextbox.ForeColor = Color.FromArgb(220, 220, 220);
            surnameTextbox.Location = new Point(398, 271);
            surnameTextbox.Name = "surnameTextbox";
            surnameTextbox.Size = new Size(336, 39);
            surnameTextbox.TabIndex = 3;
            // 
            // nameTextbox
            // 
            nameTextbox.BackColor = Color.FromArgb(69, 73, 74);
            nameTextbox.BorderStyle = BorderStyle.FixedSingle;
            nameTextbox.ForeColor = Color.FromArgb(220, 220, 220);
            nameTextbox.Location = new Point(400, 201);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(334, 39);
            nameTextbox.TabIndex = 2;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.ForeColor = Color.FromArgb(220, 220, 220);
            sexLabel.Location = new Point(248, 416);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(56, 32);
            sexLabel.TabIndex = 6;
            sexLabel.Text = "Sex:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.ForeColor = Color.FromArgb(220, 220, 220);
            genderLabel.Location = new Point(248, 487);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(97, 32);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender:";
            // 
            // idNumberTextbox
            // 
            idNumberTextbox.BackColor = Color.FromArgb(69, 73, 74);
            idNumberTextbox.BorderStyle = BorderStyle.FixedSingle;
            idNumberTextbox.ForeColor = Color.FromArgb(220, 220, 220);
            idNumberTextbox.Location = new Point(398, 130);
            idNumberTextbox.Name = "idNumberTextbox";
            idNumberTextbox.Size = new Size(336, 39);
            idNumberTextbox.TabIndex = 1;
            // 
            // idNumberLabel
            // 
            idNumberLabel.AutoSize = true;
            idNumberLabel.ForeColor = Color.FromArgb(220, 220, 220);
            idNumberLabel.Location = new Point(246, 130);
            idNumberLabel.Name = "idNumberLabel";
            idNumberLabel.Size = new Size(133, 32);
            idNumberLabel.TabIndex = 14;
            idNumberLabel.Text = "ID number:";
            // 
            // sexComboBox
            // 
            sexComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            sexComboBox.FormattingEnabled = true;
            sexComboBox.Items.AddRange(new object[] { "Female", "Male" });
            sexComboBox.Location = new Point(398, 412);
            sexComboBox.Name = "sexComboBox";
            sexComboBox.Size = new Size(175, 40);
            sexComboBox.TabIndex = 5;
            // 
            // genderComboBox
            // 
            genderComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Female", "Male", "Other" });
            genderComboBox.Location = new Point(398, 483);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(175, 40);
            genderComboBox.TabIndex = 6;
            // 
            // addPersonSaveButton
            // 
            addPersonSaveButton.Location = new Point(179, 821);
            addPersonSaveButton.Name = "addPersonSaveButton";
            addPersonSaveButton.Padding = new Padding(5);
            addPersonSaveButton.Size = new Size(251, 67);
            addPersonSaveButton.TabIndex = 8;
            addPersonSaveButton.Text = "Save Person";
            addPersonSaveButton.Click += addPersonSaveButton_Click;
            // 
            // addMemberCancelButton
            // 
            addMemberCancelButton.Location = new Point(485, 821);
            addMemberCancelButton.Name = "addMemberCancelButton";
            addMemberCancelButton.Padding = new Padding(5);
            addMemberCancelButton.Size = new Size(248, 67);
            addMemberCancelButton.TabIndex = 9;
            addMemberCancelButton.Text = "Cancel";
            addMemberCancelButton.Click += addPersonCancelButton_Click;
            // 
            // deceasedLabel
            // 
            deceasedLabel.AutoSize = true;
            deceasedLabel.ForeColor = Color.FromArgb(220, 220, 220);
            deceasedLabel.Location = new Point(246, 559);
            deceasedLabel.Name = "deceasedLabel";
            deceasedLabel.Size = new Size(122, 32);
            deceasedLabel.TabIndex = 19;
            deceasedLabel.Text = "Deceased:";
            // 
            // relationshipCheckBox
            // 
            relationshipCheckBox.AutoSize = true;
            relationshipCheckBox.Location = new Point(433, 555);
            relationshipCheckBox.Name = "relationshipCheckBox";
            relationshipCheckBox.Size = new Size(94, 36);
            relationshipCheckBox.TabIndex = 7;
            relationshipCheckBox.Text = "  Yes";
            // 
            // PersonInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(969, 955);
            Controls.Add(relationshipCheckBox);
            Controls.Add(deceasedLabel);
            Controls.Add(addMemberCancelButton);
            Controls.Add(addPersonSaveButton);
            Controls.Add(genderComboBox);
            Controls.Add(sexComboBox);
            Controls.Add(idNumberLabel);
            Controls.Add(idNumberTextbox);
            Controls.Add(genderLabel);
            Controls.Add(sexLabel);
            Controls.Add(nameTextbox);
            Controls.Add(surnameTextbox);
            Controls.Add(ageNumeric);
            Controls.Add(ageLabel);
            Controls.Add(surnameLabel);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Member";
            ((System.ComponentModel.ISupportInitialize)ageNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CrownLabel nameLabel;
        private ReaLTaiizor.Controls.CrownLabel surnameLabel;
        private ReaLTaiizor.Controls.CrownLabel ageLabel;
        private ReaLTaiizor.Controls.CrownNumeric ageNumeric;
        private ReaLTaiizor.Controls.CrownTextBox surnameTextbox;
        private ReaLTaiizor.Controls.CrownTextBox nameTextbox;
        private ReaLTaiizor.Controls.CrownLabel sexLabel;
        private ReaLTaiizor.Controls.CrownLabel genderLabel;
        private ReaLTaiizor.Controls.CrownTextBox idNumberTextbox;
        private ReaLTaiizor.Controls.CrownLabel idNumberLabel;
        private ReaLTaiizor.Controls.CrownComboBox sexComboBox;
        private ReaLTaiizor.Controls.CrownComboBox genderComboBox;
        private ReaLTaiizor.Controls.CrownButton addPersonSaveButton;
        private ReaLTaiizor.Controls.CrownButton addMemberCancelButton;
        private ReaLTaiizor.Controls.CrownLabel deceasedLabel;
        private ReaLTaiizor.Controls.CrownCheckBox relationshipCheckBox;
    }
}