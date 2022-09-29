namespace PomodoroTimerV2
{

    public enum PomodoroState
    {
        Focus,
        Break,
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FocusMinutes = 30;
            BreakMinutes = 1;
            CurrentSession = 1;
            State = PomodoroState.Focus;
            Time = new TimeOnly(0, FocusMinutes, 0);
            lblTime.Text = Time.ToString("mm:ss");
            IsActive = false;
        }

        private int FocusMinutes { get; set; }
        private int BreakMinutes { get; set; }
        private TimeOnly Time { get; set; }
        private int CurrentSession { get; set; }
        private PomodoroState State { get; set; }
        private bool IsActive { get; set; }
        private PomodoroSettings SettingsForm { get; set; }


        private void btnPauseClick(object sender, EventArgs e)
        {
            if (IsActive)
            {
                pomodoroTimer.Enabled = false;
                lblTimerStatus.Text = "Pause";
            }
        }

        private void btnStartClick(object sender, EventArgs e)
        {
            pomodoroTimer.Enabled = true;
            lblTimerStatus.Text = "Minutes Left";
            IsActive = true;
            lblStateDebug.Text = $"Session: {CurrentSession}";

            if (State == PomodoroState.Focus) lblPomodoroStatus.Text = "FOCUS";
            if (State == PomodoroState.Break) lblPomodoroStatus.Text = "BREAK";
        }

        private void btnResetClick(object sender, EventArgs e)
        {
            ResetTime();
        }

        private void pomodoroTimerTick(object sender, EventArgs e)
        {
            UpdateTime();

            if (Time.Minute == 0 && Time.Second == 0)
            {
                pomodoroTimer.Enabled = false;
                IsActive = false;

                ChangeState();
            }
        }

        private void UpdateTime()
        {
            Time = Time.Add(new TimeSpan(0, 0, -1));
            lblTime.Text = Time.ToString("mm:ss");
        }

        private void ResetTime()
        {
            pomodoroTimer.Enabled=false;
            IsActive = false;
            Time = new TimeOnly(0, FocusMinutes, 0);
            lblTime.Text = Time.ToString("mm:ss");
            lblPomodoroStatus.Text = "POMODORO TIMER";
            lblTimerStatus.Text = "Minutes Left";
        }

        private void ChangeState()
        {
            switch (State)
            {
                case PomodoroState.Focus:
                    State = PomodoroState.Break;
                    Time = new TimeOnly(0, BreakMinutes, 0);
                    lblTime.Text = Time.ToString("mm:ss");
                    lblPomodoroStatus.Text = "BREAK";
                    break;
                case PomodoroState.Break:
                    State = PomodoroState.Focus;
                    Time = new TimeOnly(0, FocusMinutes, 0);
                    lblTime.Text = Time.ToString("mm:ss");
                    lblPomodoroStatus.Text = "FOCUS";
                    CurrentSession++;
                    break;
                default:
                    break;
            }
        }

        private void btnSettingsClick(object sender, EventArgs e)
        {
            SettingsForm = new PomodoroSettings(FocusMinutes, BreakMinutes);
            SettingsForm.TimeChanged += UpdateFocusAndBreakTime;
            SettingsForm.Show();
            SettingsForm.FormClosed += (object sender, FormClosedEventArgs e) => btnSettings.Enabled = true;

            btnSettings.Enabled = false;
        }

        private void UpdateFocusAndBreakTime(object sender, EventArgs e)
        {
            var settingsForm = sender as PomodoroSettings;
            FocusMinutes = settingsForm.FocusTime;
            BreakMinutes = settingsForm.BreakTime;
            ResetTime();
        }
    }
}