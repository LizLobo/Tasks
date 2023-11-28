using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Task1_CountdownTimer
{
    public partial class Task1_CountdownTimer : Form
    {
        private int _nStartTime;
        private int _nStepValue;
        private bool _isCounting = false;
        private bool _isPaused = false;
        private CancellationTokenSource _cancellationTokenSource;


        public Task1_CountdownTimer()
        {
            InitializeComponent();
            durationNum.ValueChanged += durationNum_ValueChanged;
            stepNum.ValueChanged += stepNum_ValueChanged;
            counterDisplay.ReadOnly = true;
        }



        private void StartCounterButton_Click(object sender, EventArgs e)
        {
            if (stepNum.Value <= 0 || durationNum.Value <= 0)
            {
                MessageBox.Show("Duration and step number should be positive values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (stepNum.Value > durationNum.Value)
            {
                MessageBox.Show("Step number cannot be bigger than duration.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_isCounting)
            {

                counterDisplay.Text = _nStartTime.ToString();
                


                if (methodSwitch.Switched)
                {
                    CountDownAsync();
                }
                else
                {
                    CountDownTimer();
                }

                methodSwitch.Enabled = false;
            }
        }
        public async void CountDownAsync()
        {
            _isCounting = true;
            _cancellationTokenSource = new CancellationTokenSource();

           
            while (_nStartTime > 0)
            {
                if (_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    _isCounting = false;
                    break;
                }

                if (!_isPaused)
                {
                    int delay = Math.Min(_nStartTime, _nStepValue);
                    _nStartTime -= delay;

                    await Task.Delay(delay * 1000);
                    counterDisplay.Text = _nStartTime.ToString();
                }
                else
                {
                    await Task.Delay(100); // Small delay while paused
                }
            }

            _isCounting = false;
            _isPaused = false;
            methodSwitch.Enabled = true;
            _nStartTime = 0;
            _nStepValue = 0;
            counterDisplay.Text = _nStartTime.ToString();
            stepNum.Value = _nStepValue;
            durationNum.Value = _nStartTime;

        }

        public void CountDownTimer()
        {
            _isCounting = true;
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
            if (!_isCounting)
            {
                return;
            }


            if (_nStartTime <= 0)
            {
                countdownTimer.Stop();
                _isCounting = false;
                methodSwitch.Enabled = true;

                _nStartTime = 0;
                _nStepValue = 0;
                counterDisplay.Text = _nStartTime.ToString();
                stepNum.Value = _nStepValue;
                durationNum.Value = _nStartTime;

                return;
            }

            if (!_isPaused)
            {
                if (_nStartTime % _nStepValue != 0)
                {
                    int delay = Math.Min(_nStartTime, _nStepValue);
                    _nStartTime -= delay;
                    counterDisplay.Text = _nStartTime.ToString();

                    // Adjust the timer's interval to simulate a delay in milliseconds
                    countdownTimer.Interval = delay * 1000;
                    return;
                }
            }
            
                _nStartTime -= _nStepValue;
                counterDisplay.Text = _nStartTime.ToString();
        }

        public void durationNum_ValueChanged(object sender, EventArgs e)
        {
            _nStartTime = Convert.ToInt32(durationNum.Value);
            CheckForInaccuracies();

            if (_isCounting)
            {
                if (methodSwitch.Switched)
                {
                    countdownTimer.Stop();
                    if (!_isPaused)
                    {
                        _cancellationTokenSource?.Cancel();
                    }
                    counterDisplay.Text = _nStartTime.ToString();
                    CountDownAsync();
                }
                else
                {
                    _isCounting = false;
                    countdownTimer.Stop();
                    counterDisplay.Text = _nStartTime.ToString();
                    CountDownTimer();
                }
            }
            else
            {
                counterDisplay.Text = _nStartTime.ToString();
            }
        }

        public void stepNum_ValueChanged(object sender, EventArgs e)
        {
            _nStepValue = Convert.ToInt32(stepNum.Value);
            CheckForInaccuracies();

            if (_isCounting)
            {
                if (methodSwitch.Switched)
                {
                    _cancellationTokenSource?.Cancel();
                    counterDisplay.Text = _nStartTime.ToString();
                    CountDownAsync();
                }
                else
                {
                    _isCounting = false;
                    countdownTimer.Stop();
                    counterDisplay.Text = _nStartTime.ToString();
                    CountDownTimer();
                }
            }
        }

        private void CheckForInaccuracies()
        {



            if (_nStepValue != 0 && _nStartTime % _nStepValue != 0)
            {
                inaccuracyLabel.Visible = true;
                inaccuracyLabel.Text = $"Note: Inaccuracies may occur due to remainder being {_nStartTime % _nStepValue}.";
            }
            else
            {
                inaccuracyLabel.Visible = false;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (_isCounting)
            {
                _cancellationTokenSource?.Cancel();
                _isCounting = false;
                _isPaused = false;

                // Reset start number and step number to their default values
                _nStartTime = 0; 
                _nStepValue = 0; 

                // Update the counter display with the default start number
                counterDisplay.Text = _nStartTime.ToString();
                stepNum.Value = _nStepValue;
                durationNum.Value = _nStartTime;
                methodSwitch.Enabled = true;
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (_isCounting)
            {
                _isPaused = !_isPaused;
                // Change the text of the pause button based on the pause state
                PauseButton.Text = _isPaused ? "Resume" : "Pause";
            }
        }
    }
}

