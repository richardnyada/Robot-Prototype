

namespace SpiderRobots.Service
{
    public interface IControl
    {
        char Name { get; }

        void Navigate(ILocation location);

    }
}
