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
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            timerLabel = new ReaLTaiizor.Controls.SkyLabel();
            asyncLabel = new ReaLTaiizor.Controls.SkyLabel();
            methodSwitch = new ReaLTaiizor.Controls.MetroSwitch();
            countdownTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            durationNum = new ReaLTaiizor.Controls.CrownNumeric();
            stepNum = new ReaLTaiizor.Controls.CrownNumeric();
            StartCounterButton = new ReaLTaiizor.Controls.CrownButton();
            inaccuracyLabel = new ReaLTaiizor.Controls.CrownLabel();
            PauseButton = new ReaLTaiizor.Controls.CrownButton();
            StopButton = new ReaLTaiizor.Controls.CrownButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)durationNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stepNum).BeginInit();
            SuspendLayout();
            // 
            // counterDisplay
            // 
            counterDisplay.ActiveBorderColor = Color.FromArgb(43, 48, 67);
            counterDisplay.BackColor = Color.FromArgb(43, 48, 67);
            counterDisplay.BaseBackColor = Color.FromArgb(43, 48, 67);
            counterDisplay.ColorBordersOnEnter = true;
            counterDisplay.DisableBorderColor = Color.FromArgb(60, 63, 80);
            counterDisplay.Font = new Font("Unispace", 21.8571415F, FontStyle.Bold, GraphicsUnit.Point);
            counterDisplay.ForeColor = Color.FromArgb(127, 131, 140);
            counterDisplay.Image = null;
            counterDisplay.Location = new Point(182, 70);
            counterDisplay.MaxLength = 32767;
            counterDisplay.Multiline = false;
            counterDisplay.Name = "counterDisplay";
            counterDisplay.ReadOnly = false;
            counterDisplay.ShortcutsEnabled = true;
            counterDisplay.ShowBottomBorder = true;
            counterDisplay.ShowTopBorder = true;
            counterDisplay.Size = new Size(577, 94);
            counterDisplay.TabIndex = 0;
            counterDisplay.TextAlignment = HorizontalAlignment.Center;
            counterDisplay.UseSystemPasswordChar = false;
            counterDisplay.Watermark = "";
            counterDisplay.WatermarkColor = Color.FromArgb(116, 120, 129);
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Unispace", 9.857142F, FontStyle.Bold, GraphicsUnit.Point);
            skyLabel1.ForeColor = Color.Silver;
            skyLabel1.Location = new Point(182, 213);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(124, 28);
            skyLabel1.TabIndex = 4;
            skyLabel1.Text = "Duration";
            // 
            // skyLabel2
            // 
            skyLabel2.AutoSize = true;
            skyLabel2.Font = new Font("Unispace", 9.857142F, FontStyle.Bold, GraphicsUnit.Point);
            skyLabel2.ForeColor = Color.Silver;
            skyLabel2.Location = new Point(182, 273);
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
            timerLabel.Location = new Point(220, 376);
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
            asyncLabel.Location = new Point(650, 376);
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
            methodSwitch.Location = new Point(449, 382);
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
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 41);
            panel1.TabIndex = 11;
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
            nightControlBox1.Location = new Point(799, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 2;
            label1.Text = "Countdown Timer";
            // 
            // durationNum
            // 
            durationNum.Location = new Point(628, 209);
            durationNum.Name = "durationNum";
            durationNum.Size = new Size(131, 35);
            durationNum.TabIndex = 12;
            durationNum.ValueChanged += durationNum_ValueChanged;
            // 
            // stepNum
            // 
            stepNum.Location = new Point(628, 269);
            stepNum.Name = "stepNum";
            stepNum.Size = new Size(131, 35);
            stepNum.TabIndex = 13;
            stepNum.ValueChanged += stepNum_ValueChanged;
            // 
            // StartCounterButton
            // 
            StartCounterButton.Location = new Point(182, 459);
            StartCounterButton.Name = "StartCounterButton";
            StartCounterButton.Padding = new Padding(5);
            StartCounterButton.Size = new Size(178, 67);
            StartCounterButton.TabIndex = 14;
            StartCounterButton.Text = "Start";
            StartCounterButton.Click += StartCounterButton_Click;
            // 
            // inaccuracyLabel
            // 
            inaccuracyLabel.AutoSize = true;
            inaccuracyLabel.ForeColor = Color.FromArgb(220, 220, 220);
            inaccuracyLabel.Location = new Point(302, 323);
            inaccuracyLabel.Name = "inaccuracyLabel";
            inaccuracyLabel.Size = new Size(0, 30);
            inaccuracyLabel.TabIndex = 15;
            // 
            // PauseButton
            // 
            PauseButton.Location = new Point(382, 459);
            PauseButton.Name = "PauseButton";
            PauseButton.Padding = new Padding(5);
            PauseButton.Size = new Size(178, 67);
            PauseButton.TabIndex = 16;
            PauseButton.Text = "Pause";
            PauseButton.Click += PauseButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(581, 459);
            StopButton.Name = "StopButton";
            StopButton.Padding = new Padding(5);
            StopButton.Size = new Size(178, 67);
            StopButton.TabIndex = 17;
            StopButton.Text = "Stop";
            StopButton.Click += StopButton_Click;
            // 
            // Task1_CountdownTimer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 24, 29);
            ClientSize = new Size(938, 553);
            Controls.Add(StopButton);
            Controls.Add(PauseButton);
            Controls.Add(inaccuracyLabel);
            Controls.Add(StartCounterButton);
            Controls.Add(stepNum);
            Controls.Add(durationNum);
            Controls.Add(panel1);
            Controls.Add(methodSwitch);
            Controls.Add(asyncLabel);
            Controls.Add(timerLabel);
            Controls.Add(skyLabel2);
            Controls.Add(skyLabel1);
            Controls.Add(counterDisplay);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Task1_CountdownTimer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)durationNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)stepNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.NightTextBox counterDisplay;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyLabel timerLabel;
        private ReaLTaiizor.Controls.SkyLabel asyncLabel;
        private ReaLTaiizor.Controls.MetroSwitch methodSwitch;
        private System.Windows.Forms.Timer countdownTimer;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private ReaLTaiizor.Controls.CrownNumeric durationNum;
        private ReaLTaiizor.Controls.CrownNumeric stepNum;
        private ReaLTaiizor.Controls.CrownButton StartCounterButton;
        private ReaLTaiizor.Controls.CrownLabel inaccuracyLabel;
        private ReaLTaiizor.Controls.CrownButton PauseButton;
        private ReaLTaiizor.Controls.CrownButton StopButton;
    }
}