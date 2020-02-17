using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace alarmClock
{
    class FlickerAlarmClock : AlarmClock
    {
        public FlickerAlarmClock(SolidColorBrush brush)
        {
            
        }

        public override void Go()
        {
            throw new NotImplementedException();
        }
        public override void Reset()
        {
            base.Reset();
        }
    }

}
