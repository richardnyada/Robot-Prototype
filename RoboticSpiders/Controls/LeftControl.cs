
using SpiderRobots.Service;

namespace SpiderRobots.Controls
{
    public class LeftControl : IControl
    {
        public char Name => (char)ControlList.L;

        public void Navigate(ILocation location)
        {
            switch (location.Orientation)
            {
                case Orientation.Up:
                    location.Orientation = Orientation.Left;
                    break;
                case Orientation.Right:
                    location.Orientation = Orientation.Up;
                    break;
                case Orientation.Down:
                    location.Orientation = Orientation.Right;
                    break;
                case Orientation.Left:
                    location.Orientation = Orientation.Down;
                    break;
            }

        }
    }
}
