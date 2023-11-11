namespace Task1_CountdownTimer
{
    partial class Task1_CountdownTimer
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
            counterDisplay = new ReaLTaiizor.Controls.NightTextBox();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            durationNum = new ReaLTaiizor.Controls.SkyNumeric();
            stepNum = new ReaLTaiizor.Controls.SkyNumeric();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            timerLabel = new ReaLTaiizor.Controls.SkyLabel();
            asyncLabel = new ReaLTaiizor.Controls.SkyLabel();
            methodSwitch = new ReaLTaiizor.Controls.MetroSwitch();
            countdownTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // counterDisplay
            // 
            counterDisplay.ActiveBorderColor = Color.FromArgb(43, 48, 67);
            counterDisplay.BackColor = Color.FromArgb(43, 48, 67);
            counterDisplay.BaseBackColor = Color.FromArgb(43, 48, 67);
            counterDisplay.ColorBordersOnEnter = true;
            counterDisplay.DisableBorderColor = Color.FromArgb(60, 63, 80);
            counterDisplay.Font = new Font("Azonix", 21.8571415F, FontStyle.Regular, GraphicsUnit.Point);
            counterDisplay.ForeColor = Color.FromArgb(127, 131, 140);
            counterDisplay.Image = null;
            counterDisplay.Location = new Point(298, 52);
            counterDisplay.MaxLength = 32767;
            counterDisplay.Multiline = false;
            counterDisplay.Name = "counterDisplay";
            counterDisplay.ReadOnly = false;
            counterDisplay.ShortcutsEnabled = true;
            counterDisplay.ShowBottomBorder = true;
            counterDisplay.ShowTopBorder = true;
            counterDisplay.Size = new Size(337, 84);
            counterDisplay.TabIndex = 0;
            counterDisplay.TextAlignment = HorizontalAlignment.Center;
            counterDisplay.UseSystemPasswordChar = false;
            counterDisplay.Watermark = "";
            counterDisplay.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Azonix", 11.1428566F, FontStyle.Regular, GraphicsUnit.Point);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(348, 417);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(228, 88);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 1;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Start";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += startBtn_Click;
            // 
            // durationNum
            // 
            durationNum.BackColor = Color.FromArgb(233, 233, 233);
            durationNum.BorderColorA = Color.FromArgb(220, 220, 220);
            durationNum.BorderColorB = Color.FromArgb(228, 228, 228);
            durationNum.BorderColorC = Color.FromArgb(191, 191, 191);
            durationNum.BorderColorD = Color.FromArgb(254, 254, 254);
            durationNum.BotTriangleColor = Color.FromArgb(27, 94, 137);
            durationNum.ButtonBackColorA = Color.FromArgb(245, 245, 245);
            durationNum.ButtonBackColorB = Color.FromArgb(232, 232, 232);
            durationNum.ButtonBorderColorA = Color.FromArgb(252, 252, 252);
            durationNum.ButtonBorderColorB = Color.FromArgb(190, 190, 190);
            durationNum.ButtonBorderColorC = Color.FromArgb(200, 167, 167, 167);
            durationNum.ButtonBorderColorD = Color.FromArgb(188, 188, 188);
            durationNum.ButtonBorderColorE = Color.FromArgb(252, 252, 252);
            durationNum.Font = new Font("Azonix", 9F, FontStyle.Bold, GraphicsUnit.Point);
            durationNum.ForeColor = Color.FromArgb(29, 200, 238);
            durationNum.Location = new Point(504, 213);
            durationNum.Maximum = 9999999L;
            durationNum.Minimum = 0L;
            durationNum.Name = "durationNum";
            durationNum.Size = new Size(131, 30);
            durationNum.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            durationNum.TabIndex = 2;
            durationNum.Text = "skyNumeric1";
            durationNum.TopTriangleColor = Color.FromArgb(27, 94, 137);
            durationNum.Value = 0L;
            // 
            // stepNum
            // 
            stepNum.BackColor = Color.FromArgb(233, 233, 233);
            stepNum.BorderColorA = Color.FromArgb(220, 220, 220);
            stepNum.BorderColorB = Color.FromArgb(228, 228, 228);
            stepNum.BorderColorC = Color.FromArgb(191, 191, 191);
            stepNum.BorderColorD = Color.FromArgb(254, 254, 254);
            stepNum.BotTriangleColor = Color.FromArgb(27, 94, 137);
            stepNum.ButtonBackColorA = Color.FromArgb(245, 245, 245);
            stepNum.ButtonBackColorB = Color.FromArgb(232, 232, 232);
            stepNum.ButtonBorderColorA = Color.FromArgb(252, 252, 252);
            stepNum.ButtonBorderColorB = Color.FromArgb(190, 190, 190);
            stepNum.ButtonBorderColorC = Color.FromArgb(200, 167, 167, 167);
            stepNum.ButtonBorderColorD = Color.FromArgb(188, 188, 188);
            stepNum.ButtonBorderColorE = Color.FromArgb(252, 252, 252);
            stepNum.Font = new Font("Azonix", 9F, FontStyle.Bold, GraphicsUnit.Point);
            stepNum.ForeColor = Color.FromArgb(29, 200, 238);
            stepNum.Location = new Point(504, 273);
            stepNum.Maximum = 9999999L;
            stepNum.Minimum = 0L;
            stepNum.Name = "stepNum";
            stepNum.Size = new Size(131, 30);
            stepNum.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            stepNum.TabIndex = 3;
            stepNum.Text = "skyNumeric2";
            stepNum.TopTriangleColor = Color.FromArgb(27, 94, 137);
            stepNum.Value = 0L;
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Unispace", 9.857142F, FontStyle.Bold, GraphicsUnit.Point);
            skyLabel1.ForeColor = Color.FromArgb(29, 200, 238);
            skyLabel1.Location = new Point(298, 213);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(124, 28);
            skyLabel1.TabIndex = 4;
            skyLabel1.Text = "Duration";
            // 
            // skyLabel2
            // 
            skyLabel2.AutoSize = true;
            skyLabel2.Font = new Font("Unispace", 9.857142F, FontStyle.Bold, GraphicsUnit.Point);
            skyLabel2.ForeColor = Color.FromArgb(29, 200, 238);
            skyLabel2.Location = new Point(298, 273);
            skyLabel2.Name = "skyLabel2";
            skyLabel2.Size = new Size(166, 28);
            skyLabel2.TabIndex = 5;
            skyLabel2.Text = "Step number";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Unispace", 9.857142F, FontStyle.Bold, GraphicsUnit.Point);
            timerLabel.ForeColor = Color.FromArgb(128, 255, 128);
            timerLabel.Location = new Point(298, 339);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(82, 28);
            timerLabel.TabIndex = 7;
            timerLabel.Text = "Timer";
            // 
            // asyncLabel
            // 
            asyncLabel.AutoSize = true;
            asyncLabel.Font = new Font("Unispace", 9.857142F, FontStyle.Bold, GraphicsUnit.Point);
            asyncLabel.ForeColor = Color.FromArgb(29, 200, 238);
            asyncLabel.Location = new Point(553, 337);
            asyncLabel.Name = "asyncLabel";
            asyncLabel.Size = new Size(82, 28);
            asyncLabel.TabIndex = 9;
            asyncLabel.Text = "Async";
            // 
            // methodSwitch
            // 
            methodSwitch.BackColor = Color.Transparent;
            methodSwitch.BackgroundColor = Color.Empty;
            methodSwitch.BorderColor = Color.FromArgb(165, 159, 147);
            methodSwitch.CheckColor = Color.FromArgb(65, 177, 225);
            methodSwitch.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            methodSwitch.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            methodSwitch.DisabledCheckColor = Color.FromArgb(100, 65, 177, 225);
            methodSwitch.DisabledUnCheckColor = Color.FromArgb(200, 205, 205, 205);
            methodSwitch.IsDerivedStyle = true;
            methodSwitch.Location = new Point(433, 343);
            methodSwitch.Name = "methodSwitch";
            methodSwitch.Size = new Size(58, 22);
            methodSwitch.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            methodSwitch.StyleManager = null;
            methodSwitch.Switched = false;
            methodSwitch.SymbolColor = Color.FromArgb(92, 92, 92);
            methodSwitch.TabIndex = 10;
            methodSwitch.Text = "metroSwitch1";
            methodSwitch.ThemeAuthor = "Taiizor";
            methodSwitch.ThemeName = "MetroLight";
            methodSwitch.UnCheckColor = Color.FromArgb(155, 155, 155);
            methodSwitch.SwitchedChanged += methodSwitch_SwitchedChanged;
            // 
            // countdownTimer
            // 
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += countdownTimer_Tick;
            // 
            // Task1_CountdownTimer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 553);
            Controls.Add(methodSwitch);
            Controls.Add(asyncLabel);
            Controls.Add(timerLabel);
            Controls.Add(skyLabel2);
            Controls.Add(skyLabel1);
            Controls.Add(stepNum);
            Controls.Add(durationNum);
            Controls.Add(cyberButton1);
            Controls.Add(counterDisplay);
            Name = "Task1_CountdownTimer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.NightTextBox counterDisplay;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.SkyNumeric durationNum;
        private ReaLTaiizor.Controls.SkyNumeric stepNum;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyLabel timerLabel;
        private ReaLTaiizor.Controls.SkyLabel asyncLabel;
        private ReaLTaiizor.Controls.MetroSwitch methodSwitch;
        private System.Windows.Forms.Timer countdownTimer;
    }
}