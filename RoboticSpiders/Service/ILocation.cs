

using SpiderRobots.Model;

namespace SpiderRobots.Service
{
    public interface ILocation
    {
        Wall Wall { get; set; }

        int X { get; set; }

        int Y { get; set; }

        Orientation Orientation { get; set; }

        void SetOrientation(string orientation);
    }
}
