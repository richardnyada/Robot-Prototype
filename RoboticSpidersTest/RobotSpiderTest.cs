using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpiderRobots;
using SpiderRobots.Controls;
using SpiderRobots.Model;
using SpiderRobots.Service;

namespace SpiderRobotsTest
{
    [TestClass]
    public class RobotSpiderTest
    {
        private Wall _wall;
        private INavigationControls _controlsConfig;
        private IRobot _spider;
        
        [TestInitialize]
        public void Init()
        {
            _wall = new Wall(){ X = 7, Y = 15};
            _controlsConfig = new NavigationControls();
        }

        [TestCleanup]
        public void Cleanup()
        {
           _wall = null;
           _controlsConfig = null;

        }

        [DataRow(7, 15, Orientation.Up, "F", "7 15 Up")]
        [DataRow(0, 0, Orientation.Up, "F", "0 1 Up")]
        [DataRow(2, 4, Orientation.Left, "FLFLFRFFLF", "3 1 Right")]
        [DataRow(2, 4, Orientation.Right, "FLFLFRFFLF", "1 7 Left")]
        [DataRow(8, 16, Orientation.Up, "F", "The Spider's position is not on the wall.")]
        [DataTestMethod]
        public void SpiderCorrectly_ExploredWall(int x, int y, Orientation d, string instructions, string result)
        {
            var location = new Location(_wall, x, y, d);
            _spider = new RoboticSpider(_controlsConfig, location);


            var actual = _spider.Explore(instructions);


            Assert.AreEqual(result, actual);

        }
        
        
    }
}
