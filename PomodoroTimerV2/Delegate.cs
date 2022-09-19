using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimerV2
{
    public delegate void SetTimerValue(int value);
    public delegate void GetTimerValue(int focusTime, int breakTime);
}
