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
            lblSetTimeFocus.Text = Form1.Instance.FocusMinutes.ToString();
            lblSetTimeBreak.Text = Form1.Instance.BreakMinutes.ToString();
        }

        private void btnChangeTime(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button.Name == "btnAddTimeFocus")
            {
                Form1.Instance.FocusMinutes++;
                Form1.Instance.ResetTime();
                lblSetTimeFocus.Text = Form1.Instance.FocusMinutes.ToString();
            }
            else if (button.Name == "btnMinusTimeFocus")
            {
                Form1.Instance.FocusMinutes--;
                Form1.Instance.ResetTime();
                lblSetTimeFocus.Text = Form1.Instance.FocusMinutes.ToString();
            }
            else if (button.Name == "btnAddTimeBreak")
            {
                Form1.Instance.BreakMinutes++;
                lblSetTimeBreak.Text = Form1.Instance.BreakMinutes.ToString();
            }
            else if (button.Name == "btnMinusTimeBreak")
            {
                Form1.Instance.BreakMinutes--;
                lblSetTimeBreak.Text = Form1.Instance.BreakMinutes.ToString();
            }
        }
    }
}
