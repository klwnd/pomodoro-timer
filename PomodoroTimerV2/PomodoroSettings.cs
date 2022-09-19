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
        public PomodoroSettings()
        {
            InitializeComponent();
        }

        public SetTimerValue SetWorkTime;
        public SetTimerValue SetBreakTime;

        private void btnChangeTime(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button.Name == "btnAddTimeFocus")
            {
                SetWorkTime(1);  
            }
            else if (button.Name == "btnMinusTimeFocus")
            {
                SetWorkTime(-1);
            }
            else if (button.Name == "btnAddTimeBreak")
            {
                SetBreakTime(1);
            }
            else if (button.Name == "btnMinusTimeBreak")
            {
                SetBreakTime(-1);
            }
        }

        public void UpdateLblTime(int focusTime, int breakTime)
        {
            lblSetTimeFocus.Text = focusTime.ToString();
            lblSetTimeBreak.Text = breakTime.ToString();
        }
    }
}
