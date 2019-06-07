using System;
using SpiderRobots;
using SpiderRobots.Controls;
using SpiderRobots.Model;
using SpiderRobots.Service;

namespace ConsoleAppExample
{
    class Program
    {
        /// <summary>
        /// Console application. A rough but quick example utilizing the Robotic Spider classes  
        /// </summary>
        static void Main(string[] args)
        {
            Wall wall = null;
            var wallCompleted = false;

            //Loop until the wall has been successfully created
            while (!wallCompleted)
            {
                wall = CreateWall(out wallCompleted);
                
            }

            //Continuous loop, until the program has been terminated, allowing a user to create as many spiders as they want with instructions to explore the wall 
            while (true)
            {
                RobotSpiderControl(wall);
                
            }

        }


        static Wall CreateWall(out bool wallCompleted)
        {
            Wall wall = null;
            wallCompleted = false;

            try
            {   // Wall Size Definition
                var input1 = Console.ReadLine();  // First line Input Format eg: 7 15

                var w = input1.Trim().Split(' ');

                if (w.Length == 2 && int.TryParse(w[0], out int x) == true && int.TryParse(w[1], out int y) == true)
                {
                    wall = new Wall { X = x, Y = y };

                    wallCompleted = true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return wall;

        }



        static void RobotSpiderControl(Wall wall)
        {
            try
            {
                // Robotic Spider Location & Orientation Definition
                var input2 = Console.ReadLine();  // Second line Input Format eg: 2 4 Left

                var s = input2.Trim().Split(' ');

                ILocation position = new Location(wall, int.Parse(s[0]), int.Parse(s[1]), s[2]);

                INavigationControls controlsConfig = new NavigationControls();

                IRobot spider = new RoboticSpider(controlsConfig, position);

                var input3 = Console.ReadLine();  // Third line Instructions Input Format eg: FLFLFRFFLF
                

                // Robotic Spider Explore function call
                var n = spider.Explore(input3.Trim());

                Console.WriteLine(n); //If using the examples the out put should be: 3 1 Right
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
