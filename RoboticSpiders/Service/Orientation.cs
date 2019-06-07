using System;

namespace SpiderRobots.Service
{
    [Flags()]
    public enum Orientation
    {
        None = 0,
        Up = 1,
        Right = 2,
        Down = 3,
        Left = 4
    }
}
