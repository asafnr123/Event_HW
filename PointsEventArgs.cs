using System;

namespace Event_HW
{
    public class PointsEventArgs : EventArgs
    {
        public int ShipHPRecovered { get; set; }

        public int ShipCurrentHealth { get; set; }

        public short ShipDamagedTaken { get; set; }

        public PointsEventArgs(int currentHealth, int healthRecovered)
        {
            ShipCurrentHealth = currentHealth;
            ShipHPRecovered = healthRecovered;
        }

        public PointsEventArgs(int currentHealth, short damage)
        {
            ShipCurrentHealth = currentHealth;
            ShipDamagedTaken = damage;
        }
        
    }
}