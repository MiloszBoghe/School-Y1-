using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Oef8
{
    class AlarmClock
    {
        private DateTime alarmTime;
        private int seconds = 10;



        //Methods
        public DateTime getCurrentTime()
        {
            return DateTime.Now;
        }

        public void setAlarmTime(DateTime time)
        {
            alarmTime = time;
        }

        public void setSeconds(int seconds)
        {
            this.seconds = seconds;
        }
    }
}