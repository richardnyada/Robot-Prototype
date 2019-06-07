

namespace SpiderRobots.Service
{
    public interface INavigationControls
    {
        void ExecuteControls(string instructions, ILocation location);
    }
}
