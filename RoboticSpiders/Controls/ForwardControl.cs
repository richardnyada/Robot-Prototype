
using SpiderRobots.Service;

namespace SpiderRobots.Controls
{
    public class ForwardControl : IControl
    {
        public char Name => (char)ControlList.F;

        public void Navigate(ILocation location)
        {
            switch (location.Orientation)
            {
                case Orientation.Up:
                    if (location.Wall.Y > location.Y)
                        location.Y += 1;
                    break;
                case Orientation.Right:
                    if (location.Wall.X > location.X)
                        location.X += 1;
                    break;
                case Orientation.Down:
                    if (0 < location.Y)
                        location.Y -= 1;
                    break;
                case Orientation.Left:
                    if (0 < location.X)
                        location.X -= 1;
                    break;
            }

        }
    }
}
