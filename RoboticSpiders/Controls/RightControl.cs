
using SpiderRobots.Service;

namespace SpiderRobots.Controls
{
    public class RightControl : IControl
    {
        public char Name => (char)ControlList.R;

        public void Navigate(ILocation location)
        {
            switch (location.Orientation)
            {
                case Orientation.Up:
                    location.Orientation = Orientation.Right;
                    break;
                case Orientation.Right:
                    location.Orientation = Orientation.Down;
                    break;
                case Orientation.Down:
                    location.Orientation = Orientation.Left;
                    break;
                case Orientation.Left:
                    location.Orientation = Orientation.Up;
                    break;
            }
        }
    }
}
