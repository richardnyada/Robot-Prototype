using System;
using System.Linq;
using SpiderRobots.Service;

namespace SpiderRobots.Controls
{
    public class NavigationControls : INavigationControls
    {
        private static readonly IControl[] ControlsRequest = new IControl[]
        {
            new LeftControl(),
            new RightControl(),
            new ForwardControl()
        };

        public void ExecuteControls(string instructions, ILocation location)
        {
            try
            {
                foreach (var controlType in instructions)
                {
                    var request = ControlsRequest.SingleOrDefault(x => x.Name == controlType);
                    request?.Navigate(location);
                }

            }
            catch (Exception)
            {

                /* Log Exception : Control not found */
            }

        }
    }
}
