using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BalloonInterface
{
    interface IDisplayable
    {
        void DisplayOn(Canvas drawArea);
    }
}
