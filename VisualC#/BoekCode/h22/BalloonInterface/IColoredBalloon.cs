using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BalloonInterface
{
    public interface IColoredBalloon : IBalloon
    {
        void SetColor(Color c);
    }
}
