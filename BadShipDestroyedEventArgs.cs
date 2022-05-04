using System;
namespace Event_HW
{
    public class BadShipDestroyedEventArgs : EventArgs
    {
        public int NumberOfBadShips { get; set; }

        public int BadShipDestroyed { get; set; }
        public BadShipDestroyedEventArgs(int numberOfBadShips, int shipDestroyed)
        {
            NumberOfBadShips = numberOfBadShips;
            BadShipDestroyed = shipDestroyed;
        }

    }
}