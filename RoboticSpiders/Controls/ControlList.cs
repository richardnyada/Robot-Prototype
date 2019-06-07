using System;

namespace SpiderRobots.Controls
{
    [Flags()]
    public enum ControlList
    {
        //Each character should only represents no more than one control

        F = 'F',   //Assigned to ForwardControl.cs
        L = 'L',   //Assigned to LeftControl.cs
        R = 'R'  //Assigned to RightControl.cs

    }
}
