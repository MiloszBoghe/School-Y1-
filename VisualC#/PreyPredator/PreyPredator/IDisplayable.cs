using System.Windows.Controls;
using System.Windows.Media;

namespace PreyPredator
{
    interface IDisplayable
    {
        void DisplayOn(Canvas canvas, Color color);
        void StopDisplaying();
        void UpdateDisplay();
    }
}
