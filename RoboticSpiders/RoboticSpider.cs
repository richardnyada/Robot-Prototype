using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpiderRobots.Service;

namespace SpiderRobots
{
    public class RoboticSpider : Robot
    {

        public RoboticSpider(INavigationControls navigationControls, ILocation location) : base(navigationControls, location)
        {
        }


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
