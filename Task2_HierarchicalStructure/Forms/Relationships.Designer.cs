namespace Task2_HierarchicalStructure.Forms
{
    partial class Relationships
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
            sexComboBox = new ReaLTaiizor.Controls.CrownComboBox();
            mainPersonLabel = new ReaLTaiizor.Controls.CrownLabel();
            crownComboBox1 = new ReaLTaiizor.Controls.CrownComboBox();
            relationshipTypeLabel = new ReaLTaiizor.Controls.CrownLabel();
            crownComboBox2 = new ReaLTaiizor.Controls.CrownComboBox();
            relatedPersonLabel = new ReaLTaiizor.Controls.CrownLabel();
            toLabel = new ReaLTaiizor.Controls.CrownLabel();
            cancelRelationshipButton = new ReaLTaiizor.Controls.CrownButton();
            removeRelationshipButton = new ReaLTaiizor.Controls.CrownButton();
            addRelationshipButton = new ReaLTaiizor.Controls.CrownButton();
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
            panel1.Size = new Size(1078, 41);
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
            nightControlBox1.Location = new Point(939, 0);
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
            label1.Size = new Size(154, 32);
            label1.TabIndex = 2;
            label1.Text = "Relationships";
            // 
            // sexComboBox
            // 
            sexComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            sexComboBox.FormattingEnabled = true;
            sexComboBox.Items.AddRange(new object[] { "Female", "Male" });
            sexComboBox.Location = new Point(173, 306);
            sexComboBox.Name = "sexComboBox";
            sexComboBox.Size = new Size(162, 36);
            sexComboBox.TabIndex = 17;
            // 
            // mainPersonLabel
            // 
            mainPersonLabel.AutoSize = true;
            mainPersonLabel.ForeColor = Color.FromArgb(220, 220, 220);
            mainPersonLabel.Location = new Point(189, 243);
            mainPersonLabel.Name = "mainPersonLabel";
            mainPersonLabel.Size = new Size(129, 30);
            mainPersonLabel.TabIndex = 16;
            mainPersonLabel.Text = "Main person";
            // 
            // crownComboBox1
            // 
            crownComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            crownComboBox1.FormattingEnabled = true;
            crownComboBox1.Items.AddRange(new object[] { "Female", "Male" });
            crownComboBox1.Location = new Point(406, 306);
            crownComboBox1.Name = "crownComboBox1";
            crownComboBox1.Size = new Size(175, 36);
            crownComboBox1.TabIndex = 19;
            // 
            // relationshipTypeLabel
            // 
            relationshipTypeLabel.AutoSize = true;
            relationshipTypeLabel.ForeColor = Color.FromArgb(220, 220, 220);
            relationshipTypeLabel.Location = new Point(406, 243);
            relationshipTypeLabel.Name = "relationshipTypeLabel";
            relationshipTypeLabel.Size = new Size(175, 30);
            relationshipTypeLabel.TabIndex = 18;
            relationshipTypeLabel.Text = "Relationship Type";
            // 
            // crownComboBox2
            // 
            crownComboBox2.DrawMode = DrawMode.OwnerDrawVariable;
            crownComboBox2.FormattingEnabled = true;
            crownComboBox2.Items.AddRange(new object[] { "Female", "Male" });
            crownComboBox2.Location = new Point(737, 306);
            crownComboBox2.Name = "crownComboBox2";
            crownComboBox2.Size = new Size(162, 36);
            crownComboBox2.TabIndex = 21;
            // 
            // relatedPersonLabel
            // 
            relatedPersonLabel.AutoSize = true;
            relatedPersonLabel.ForeColor = Color.FromArgb(220, 220, 220);
            relatedPersonLabel.Location = new Point(753, 243);
            relatedPersonLabel.Name = "relatedPersonLabel";
            relatedPersonLabel.Size = new Size(151, 30);
            relatedPersonLabel.TabIndex = 20;
            relatedPersonLabel.Text = "Related person";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.ForeColor = Color.FromArgb(220, 220, 220);
            toLabel.Location = new Point(644, 309);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(34, 30);
            toLabel.TabIndex = 22;
            toLabel.Text = "To";
            // 
            // cancelRelationshipButton
            // 
            cancelRelationshipButton.Location = new Point(679, 102);
            cancelRelationshipButton.Name = "cancelRelationshipButton";
            cancelRelationshipButton.Padding = new Padding(5);
            cancelRelationshipButton.Size = new Size(234, 46);
            cancelRelationshipButton.TabIndex = 25;
            cancelRelationshipButton.Text = "Cancel";
            // 
            // removeRelationshipButton
            // 
            removeRelationshipButton.Location = new Point(413, 102);
            removeRelationshipButton.Name = "removeRelationshipButton";
            removeRelationshipButton.Padding = new Padding(5);
            removeRelationshipButton.Size = new Size(234, 46);
            removeRelationshipButton.TabIndex = 24;
            removeRelationshipButton.Text = "Remove Relationship";
            // 
            // addRelationshipButton
            // 
            addRelationshipButton.Location = new Point(149, 102);
            addRelationshipButton.Name = "addRelationshipButton";
            addRelationshipButton.Padding = new Padding(5);
            addRelationshipButton.Size = new Size(234, 46);
            addRelationshipButton.TabIndex = 23;
            addRelationshipButton.Text = "Add Relationship";
            // 
            // Relationships
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(1078, 450);
            Controls.Add(cancelRelationshipButton);
            Controls.Add(removeRelationshipButton);
            Controls.Add(addRelationshipButton);
            Controls.Add(toLabel);
            Controls.Add(crownComboBox2);
            Controls.Add(relatedPersonLabel);
            Controls.Add(crownComboBox1);
            Controls.Add(relationshipTypeLabel);
            Controls.Add(sexComboBox);
            Controls.Add(mainPersonLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Relationships";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relationships";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private ReaLTaiizor.Controls.CrownComboBox sexComboBox;
        private ReaLTaiizor.Controls.CrownLabel mainPersonLabel;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox1;
        private ReaLTaiizor.Controls.CrownLabel relationshipTypeLabel;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox2;
        private ReaLTaiizor.Controls.CrownLabel relatedPersonLabel;
        private ReaLTaiizor.Controls.CrownLabel toLabel;
        private ReaLTaiizor.Controls.CrownButton cancelRelationshipButton;
        private ReaLTaiizor.Controls.CrownButton removeRelationshipButton;
        private ReaLTaiizor.Controls.CrownButton addRelationshipButton;
    }
}