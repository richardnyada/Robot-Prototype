

namespace SpiderRobots.Service
{
    public abstract class Robot : IRobot
    {
        protected readonly INavigationControls NavigationControls;
        protected readonly ILocation Location;

        protected Robot(INavigationControls navigationControls, ILocation location)
        {
            NavigationControls = navigationControls;
            Location = location;
        }

        public abstract string Explore(string instructions);
    }
}
