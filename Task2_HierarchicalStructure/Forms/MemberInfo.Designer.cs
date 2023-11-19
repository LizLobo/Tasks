namespace Task2_HierarchicalStructure
{
    partial class MemberInfo
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
            addMemberSaveButton = new ReaLTaiizor.Controls.CrownButton();
            addMemberCancelButton = new ReaLTaiizor.Controls.CrownButton();
            relationshipLabel = new ReaLTaiizor.Controls.CrownLabel();
            relationshipCheckBox = new ReaLTaiizor.Controls.CrownCheckBox();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            crownComboBox1 = new ReaLTaiizor.Controls.CrownComboBox();
            crownComboBox2 = new ReaLTaiizor.Controls.CrownComboBox();
            crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            ((System.ComponentModel.ISupportInitialize)ageNumeric).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.FromArgb(220, 220, 220);
            nameLabel.Location = new Point(248, 227);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(74, 30);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.ForeColor = Color.FromArgb(220, 220, 220);
            surnameLabel.Location = new Point(248, 293);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(100, 30);
            surnameLabel.TabIndex = 1;
            surnameLabel.Text = "Surname:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.ForeColor = Color.FromArgb(220, 220, 220);
            ageLabel.Location = new Point(248, 433);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(55, 30);
            ageLabel.TabIndex = 2;
            ageLabel.Text = "Age:";
            // 
            // ageNumeric
            // 
            ageNumeric.Location = new Point(386, 431);
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
            surnameTextbox.Location = new Point(386, 288);
            surnameTextbox.Name = "surnameTextbox";
            surnameTextbox.Size = new Size(310, 35);
            surnameTextbox.TabIndex = 4;
            // 
            // nameTextbox
            // 
            nameTextbox.BackColor = Color.FromArgb(69, 73, 74);
            nameTextbox.BorderStyle = BorderStyle.FixedSingle;
            nameTextbox.ForeColor = Color.FromArgb(220, 220, 220);
            nameTextbox.Location = new Point(388, 226);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(308, 35);
            nameTextbox.TabIndex = 5;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.ForeColor = Color.FromArgb(220, 220, 220);
            sexLabel.Location = new Point(248, 504);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(50, 30);
            sexLabel.TabIndex = 6;
            sexLabel.Text = "Sex:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.ForeColor = Color.FromArgb(220, 220, 220);
            genderLabel.Location = new Point(248, 576);
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
            idNumberTextbox.Location = new Point(386, 353);
            idNumberTextbox.Name = "idNumberTextbox";
            idNumberTextbox.Size = new Size(310, 35);
            idNumberTextbox.TabIndex = 13;
            // 
            // idNumberLabel
            // 
            idNumberLabel.AutoSize = true;
            idNumberLabel.ForeColor = Color.FromArgb(220, 220, 220);
            idNumberLabel.Location = new Point(246, 353);
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
            sexComboBox.Location = new Point(386, 504);
            sexComboBox.Name = "sexComboBox";
            sexComboBox.Size = new Size(162, 36);
            sexComboBox.TabIndex = 15;
            // 
            // genderComboBox
            // 
            genderComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Female", "Male", "Other" });
            genderComboBox.Location = new Point(386, 573);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(162, 36);
            genderComboBox.TabIndex = 16;
            // 
            // addMemberSaveButton
            // 
            addMemberSaveButton.Location = new Point(165, 770);
            addMemberSaveButton.Name = "addMemberSaveButton";
            addMemberSaveButton.Padding = new Padding(5);
            addMemberSaveButton.Size = new Size(232, 63);
            addMemberSaveButton.TabIndex = 17;
            addMemberSaveButton.Text = "Save Member";
            addMemberSaveButton.Click += addMemberSaveButton_Click;
            // 
            // addMemberCancelButton
            // 
            addMemberCancelButton.Location = new Point(448, 770);
            addMemberCancelButton.Name = "addMemberCancelButton";
            addMemberCancelButton.Padding = new Padding(5);
            addMemberCancelButton.Size = new Size(229, 63);
            addMemberCancelButton.TabIndex = 18;
            addMemberCancelButton.Text = "Cancel";
            addMemberCancelButton.Click += addMemberCancelButton_Click;
            // 
            // relationshipLabel
            // 
            relationshipLabel.AutoSize = true;
            relationshipLabel.ForeColor = Color.FromArgb(220, 220, 220);
            relationshipLabel.Location = new Point(246, 644);
            relationshipLabel.Name = "relationshipLabel";
            relationshipLabel.Size = new Size(131, 30);
            relationshipLabel.TabIndex = 19;
            relationshipLabel.Text = "Relationship:";
            // 
            // relationshipCheckBox
            // 
            relationshipCheckBox.AutoSize = true;
            relationshipCheckBox.Location = new Point(419, 644);
            relationshipCheckBox.Name = "relationshipCheckBox";
            relationshipCheckBox.Size = new Size(129, 34);
            relationshipCheckBox.TabIndex = 20;
            relationshipCheckBox.Text = "   Married";
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel1.Location = new Point(246, 101);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(129, 30);
            crownLabel1.TabIndex = 21;
            crownLabel1.Text = "Person Type:";
            // 
            // crownComboBox1
            // 
            crownComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            crownComboBox1.FormattingEnabled = true;
            crownComboBox1.Items.AddRange(new object[] { "Parent", "Child" });
            crownComboBox1.Location = new Point(386, 101);
            crownComboBox1.Name = "crownComboBox1";
            crownComboBox1.Size = new Size(162, 36);
            crownComboBox1.TabIndex = 22;
            // 
            // crownComboBox2
            // 
            crownComboBox2.DrawMode = DrawMode.OwnerDrawVariable;
            crownComboBox2.FormattingEnabled = true;
            crownComboBox2.Items.AddRange(new object[] { "Father", "Mother", "Guardian", "Partner" });
            crownComboBox2.Location = new Point(388, 159);
            crownComboBox2.Name = "crownComboBox2";
            crownComboBox2.Size = new Size(162, 36);
            crownComboBox2.TabIndex = 24;
            // 
            // crownLabel2
            // 
            crownLabel2.AutoSize = true;
            crownLabel2.ForeColor = Color.FromArgb(220, 220, 220);
            crownLabel2.Location = new Point(248, 159);
            crownLabel2.Name = "crownLabel2";
            crownLabel2.Size = new Size(139, 30);
            crownLabel2.TabIndex = 23;
            crownLabel2.Text = "Parental Role:";
            // 
            // MemberInfo
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(894, 895);
            Controls.Add(crownComboBox2);
            Controls.Add(crownLabel2);
            Controls.Add(crownComboBox1);
            Controls.Add(crownLabel1);
            Controls.Add(relationshipCheckBox);
            Controls.Add(relationshipLabel);
            Controls.Add(addMemberCancelButton);
            Controls.Add(addMemberSaveButton);
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
            Name = "MemberInfo";
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
        private ReaLTaiizor.Controls.CrownButton addMemberSaveButton;
        private ReaLTaiizor.Controls.CrownButton addMemberCancelButton;
        private ReaLTaiizor.Controls.CrownLabel relationshipLabel;
        private ReaLTaiizor.Controls.CrownCheckBox relationshipCheckBox;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox1;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox2;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
    }
}