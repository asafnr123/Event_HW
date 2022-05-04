using System;
namespace Event_HW
{
    public class LocationEventArgs : EventArgs
    {

        public int ShipXLocation { get; set; }

        public int ShipYLocation { get; set; }



        public LocationEventArgs(int x, int y)
        {
            ShipXLocation = x;
            ShipYLocation = y;
        }
    }
}