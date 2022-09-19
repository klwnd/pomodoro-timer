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
            Instance = this;
        }

        public int FocusMinutes { get; set; }
        public int BreakMinutes { get; set; }
        TimeOnly Time;
        public int CurrentSession { get; set; }
        PomodoroState State;
        public bool IsActive { get; set; }
        public static Form1 Instance;


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


        void UpdateTime()
        {
            Time = Time.Add(new TimeSpan(0, 0, -1));
            lblTime.Text = Time.ToString("mm:ss");
        }

        public void ResetTime()
        {
            pomodoroTimer.Enabled=false;
            IsActive = false;
            Time = new TimeOnly(0, FocusMinutes, 0);
            lblTime.Text = Time.ToString("mm:ss");
            lblPomodoroStatus.Text = "POMODORO TIMER";
        }

        void ChangeState()
        {
            switch (State)
            {
                case PomodoroState.Focus:
                    State = PomodoroState.Break;
                    Time = new TimeOnly(0, BreakMinutes, 5);
                    lblTime.Text = Time.ToString("mm:ss");
                    lblPomodoroStatus.Text = "BREAK";
                    break;
                case PomodoroState.Break:
                    State = PomodoroState.Focus;
                    Time = new TimeOnly(0, FocusMinutes, 10);
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
            PomodoroSettings Settings = new PomodoroSettings();

            Settings.Show();
        }
    }
}