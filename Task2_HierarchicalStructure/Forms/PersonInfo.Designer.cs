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
            nameLabel.Location = new Point(229, 189);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(74, 30);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.ForeColor = Color.FromArgb(220, 220, 220);
            surnameLabel.Location = new Point(229, 256);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(100, 30);
            surnameLabel.TabIndex = 1;
            surnameLabel.Text = "Surname:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.ForeColor = Color.FromArgb(220, 220, 220);
            ageLabel.Location = new Point(229, 323);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(55, 30);
            ageLabel.TabIndex = 2;
            ageLabel.Text = "Age:";
            // 
            // ageNumeric
            // 
            ageNumeric.Location = new Point(367, 320);
            ageNumeric.Name = "ageNumeric";
            ageNumeric.Size = new Size(162, 35);
            ageNumeric.TabIndex = 3;
            ageNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // surnameTextbox
            // 
            surnameTextbox.BackColor = Color.FromArgb(69, 73, 74);
            surnameTextbox.BorderStyle = BorderStyle.FixedSingle;
            surnameTextbox.ForeColor = Color.FromArgb(220, 220, 220);
            surnameTextbox.Location = new Point(367, 254);
            surnameTextbox.Name = "surnameTextbox";
            surnameTextbox.Size = new Size(310, 35);
            surnameTextbox.TabIndex = 4;
            // 
            // nameTextbox
            // 
            nameTextbox.BackColor = Color.FromArgb(69, 73, 74);
            nameTextbox.BorderStyle = BorderStyle.FixedSingle;
            nameTextbox.ForeColor = Color.FromArgb(220, 220, 220);
            nameTextbox.Location = new Point(369, 188);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(308, 35);
            nameTextbox.TabIndex = 5;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.ForeColor = Color.FromArgb(220, 220, 220);
            sexLabel.Location = new Point(229, 390);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(50, 30);
            sexLabel.TabIndex = 6;
            sexLabel.Text = "Sex:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.ForeColor = Color.FromArgb(220, 220, 220);
            genderLabel.Location = new Point(229, 457);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(85, 30);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender:";
            // 
            // idNumberTextbox
            // 
            idNumberTextbox.BackColor = Color.FromArgb(69, 73, 74);
            idNumberTextbox.BorderStyle = BorderStyle.FixedSingle;
            idNumberTextbox.ForeColor = Color.FromArgb(220, 220, 220);
            idNumberTextbox.Location = new Point(367, 122);
            idNumberTextbox.Name = "idNumberTextbox";
            idNumberTextbox.Size = new Size(310, 35);
            idNumberTextbox.TabIndex = 13;
            // 
            // idNumberLabel
            // 
            idNumberLabel.AutoSize = true;
            idNumberLabel.ForeColor = Color.FromArgb(220, 220, 220);
            idNumberLabel.Location = new Point(227, 122);
            idNumberLabel.Name = "idNumberLabel";
            idNumberLabel.Size = new Size(117, 30);
            idNumberLabel.TabIndex = 14;
            idNumberLabel.Text = "ID number:";
            // 
            // sexComboBox
            // 
            sexComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            sexComboBox.FormattingEnabled = true;
            sexComboBox.Items.AddRange(new object[] { "Female", "Male" });
            sexComboBox.Location = new Point(367, 386);
            sexComboBox.Name = "sexComboBox";
            sexComboBox.Size = new Size(162, 36);
            sexComboBox.TabIndex = 15;
            // 
            // genderComboBox
            // 
            genderComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Female", "Male", "Other" });
            genderComboBox.Location = new Point(367, 453);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(162, 36);
            genderComboBox.TabIndex = 16;
            // 
            // addPersonSaveButton
            // 
            addPersonSaveButton.Location = new Point(165, 770);
            addPersonSaveButton.Name = "addPersonSaveButton";
            addPersonSaveButton.Padding = new Padding(5);
            addPersonSaveButton.Size = new Size(232, 63);
            addPersonSaveButton.TabIndex = 17;
            addPersonSaveButton.Text = "Save Person";
            addPersonSaveButton.Click += addPersonSaveButton_Click;
            // 
            // addMemberCancelButton
            // 
            addMemberCancelButton.Location = new Point(448, 770);
            addMemberCancelButton.Name = "addMemberCancelButton";
            addMemberCancelButton.Padding = new Padding(5);
            addMemberCancelButton.Size = new Size(229, 63);
            addMemberCancelButton.TabIndex = 18;
            addMemberCancelButton.Text = "Cancel";
            addMemberCancelButton.Click += addPersonCancelButton_Click;
            // 
            // deceasedLabel
            // 
            deceasedLabel.AutoSize = true;
            deceasedLabel.ForeColor = Color.FromArgb(220, 220, 220);
            deceasedLabel.Location = new Point(227, 524);
            deceasedLabel.Name = "deceasedLabel";
            deceasedLabel.Size = new Size(108, 30);
            deceasedLabel.TabIndex = 19;
            deceasedLabel.Text = "Deceased:";
            // 
            // relationshipCheckBox
            // 
            relationshipCheckBox.AutoSize = true;
            relationshipCheckBox.Location = new Point(400, 520);
            relationshipCheckBox.Name = "relationshipCheckBox";
            relationshipCheckBox.Size = new Size(81, 34);
            relationshipCheckBox.TabIndex = 20;
            relationshipCheckBox.Text = "  Yes";
            // 
            // PersonInfo
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(894, 895);
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