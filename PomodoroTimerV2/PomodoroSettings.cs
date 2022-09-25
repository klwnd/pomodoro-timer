using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroTimerV2
{
    public partial class PomodoroSettings : Form
    {
        public PomodoroSettings(int focusTime, int breakTime)
        {
            InitializeComponent();
            FocusTime = focusTime;
            BreakTime = breakTime;
        }

        public event EventHandler<EventArgs> TimeChanged;
        private int _focusTime;
        private int _breakTime;

        public int FocusTime
        {
            get { return _focusTime; }

            set
            {
                if (value > 0)
                {
                    _focusTime = value;
                    lblFocusTime.Text = value.ToString();
                }
            }
        }

        public int BreakTime
        {
            get { return _breakTime; }

            set
            {
               if (value > 0)
                {
                    _breakTime = value;
                    lblBreakTime.Text = value.ToString();
                }
            }
        }

        private void btnChangeTime(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button.Name == "btnAddTimeFocus") FocusTime++;
            else if (button.Name == "btnMinusTimeFocus") FocusTime--;
            else if (button.Name == "btnAddTimeBreak") BreakTime++;
            else if (button.Name == "btnMinusTimeBreak") BreakTime--;

            OnChangeSettingsTime(null);
        }

        private void OnChangeSettingsTime(EventArgs args)
        {
            TimeChanged(this, args);
        }

       
    }
}
