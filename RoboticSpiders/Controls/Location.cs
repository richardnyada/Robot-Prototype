
using SpiderRobots.Model;
using SpiderRobots.Service;

namespace SpiderRobots.Controls
{
    public class Location : ILocation
    {
        public Location(Wall wall, int x, int y, Orientation orientation)
        {
            Wall = wall;
            X = x;
            Y = y;
            Orientation = orientation;
        }

        public Location(Wall wall, int x, int y, string orientation)
        {
            Wall = wall;
            X = x;
            Y = y;
            SetOrientation(orientation);
        }

        public Wall Wall { get; set; }

        public int X { get; set; }

        public int Y { get; set; }


        public Orientation Orientation { get; set; }


        public void SetOrientation(string orientation)
        {
            switch (orientation)
            {
                case "Up":
                    Orientation = Orientation.Up;
                    break;
                case "Right":
                    Orientation = Orientation.Right;
                    break;
                case "Down":
                    Orientation = Orientation.Down;
                    break;
                case "Left":
                    Orientation = Orientation.Left;
                    break;
                default:
                    Orientation = Orientation.Up;
                    break;
            }
        }
    }
}
