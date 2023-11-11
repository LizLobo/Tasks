namespace Task1_CountdownTimer
{
    public partial class Task1_CountdownTimer : Form
    {
        private int _nStartTime;
        private int _nStepValue;


        public Task1_CountdownTimer()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");

            counterDisplay.Text = durationNum.Value.ToString();

            _nStartTime = Convert.ToInt32(durationNum.Value);
            _nStepValue = Convert.ToInt32(stepNum.Value);
            if (methodSwitch.Switched) {CountDownAsync();}
            else {CountDownTimer(); }


        }

        public async void CountDownAsync()
        {
            while (_nStartTime > 0)
            {
                _nStartTime -= _nStepValue;
                await Task.Delay(_nStepValue * 1000);
                counterDisplay.Text = _nStartTime.ToString();

            }

        }

        public void CountDownTimer()
        {
            countdownTimer.Interval = _nStepValue * 1000;
            countdownTimer.Start();

        }


        private void methodSwitch_SwitchedChanged(object sender)
        {
            if (methodSwitch.Switched)
            {
                asyncLabel.ForeColor = Color.FromArgb(128, 255, 128);
                timerLabel.ForeColor = Color.FromArgb(29, 200, 238);
            }
            else
            {
                timerLabel.ForeColor = Color.FromArgb(128, 255, 128);
                asyncLabel.ForeColor = Color.FromArgb(29, 200, 238);
            }

        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            _nStartTime -= _nStepValue;
            counterDisplay.Text = _nStartTime.ToString();

            if (_nStartTime <= 0)
            {
                countdownTimer.Stop();
            }

        }
    }
}

