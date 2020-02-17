using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alarmClock
{
    public abstract class AlarmClock
    {
        private int _beepTimeInSeconds;
        private DateTime _alarmTime;
        public AlarmClock()
        {
            _alarmTime = DateTime.MaxValue;
            _beepTimeInSeconds = 10;
        }

        public string CurrentTime => DateTime.Now.ToLongTimeString();

        public string AlarmTime
        {
            set
            {
                _alarmTime = Convert.ToDateTime(value);
            }
        }

        public bool isAlarmPassed()
        {
            return DateTime.Now >= _alarmTime;
        }

        public bool ShouldStopBeeping()
        {
            return isAlarmPassed() ? _alarmTime.AddSeconds(_beepTimeInSeconds) < DateTime.Now : false;
        }
        public abstract void Go();

        public virtual void Reset()
        {
            _alarmTime = DateTime.MaxValue;
        }
    }
}
