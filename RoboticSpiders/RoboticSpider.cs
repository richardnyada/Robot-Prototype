
using SpiderRobots.Service;

namespace SpiderRobots
{
    public class RoboticSpider : Robot
    {

        public RoboticSpider(INavigationControls navigationControls, ILocation location) : base(navigationControls, location)
        {
        }

       //Explore method used to pass set of instructions to the spider i.e. "L" - Turn left, "R" - Turn Right, "F" - Move Forward
       //The method returns the current location of the spider on the wall after it has executed the command.
        public override string Explore(string instructions)
        {
            if (Location.X > Location.Wall.X || Location.Y > Location.Wall.Y || Location.X < 0 || Location.Y < 0)
            {
                return "The Spider's position is not on the wall.";
            }

            
            NavigationControls.ExecuteControls(instructions, Location);


            return Location.X.ToString() + " " + Location.Y.ToString() + " " + Location.Orientation.ToString();
        }




    }
}
